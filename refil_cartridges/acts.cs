using System;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using Word = Microsoft.Office.Interop.Word;

namespace refil_cartridges
{
    public partial class acts : Form
    {
        public acts()
        {
            InitializeComponent();
        }

        public void Clear(DataGridView dataGridView)
        {
            while (dataGridView.Rows.Count > 0)
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                    dataGridView.Rows.Remove(dataGridView.Rows[i]);
        }

        private void DGV_Load()
        {
            //this.tbl_aktsTableAdapter.Fill(this.baseDataSet2.tbl_akts);
            //dataGridView2.DataSource = this.baseDataSet2.tbl_akts;
            //dataGridView2.Columns["code"].DataPropertyName = "code";
            //dataGridView2.Columns["_date"].DataPropertyName = "_date";
            //dataGridView2.Columns["act_number"].DataPropertyName = "act_number";
            //dataGridView2.Columns["creater"].DataPropertyName = "creater";
            //dataGridView2.Columns["numOfrec"].DataPropertyName = "numOfrec";
            //dataGridView2.Columns[4].Visible = false;
            //dataGridView2.Columns[5].Visible = false;
            //dataGridView2.Columns[6].Visible = false;
            //dataGridView2.Columns[7].Visible = false;
            //dataGridView2.Columns[8].Visible = false;
            //dataGridView2.Columns[9].Visible = false;
            //dataGridView2.Columns[11].Visible = false;            
            this._aktsTableAdapter.Fill(this.baseDataSet._akts);
            dataGridView2.DataSource = this.baseDataSet._akts;
            dataGridView2.Columns["code"].DataPropertyName = "Код";
            dataGridView2.Columns["_date"].DataPropertyName = "_date";
            dataGridView2.Columns["act_number"].DataPropertyName = "act_number";
            dataGridView2.Columns["creater"].DataPropertyName = "creater";
            dataGridView2.Columns["numOfrec"].DataPropertyName = "numOfrec";
            dataGridView2.Columns[4].Visible = false;
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[6].Visible = false;
            dataGridView2.Columns[7].Visible = false;
        }

        private void acts_Load(object sender, EventArgs e)
        {
            button1.Visible = button2.Visible = button3.Visible = button4.Visible = button5.Visible = false;           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text != "Картридж")
            {
                comboBox3.DataSource = printersBindingSource;
                comboBox3.DisplayMember = "printer_model";
                textBox2.DataBindings.Clear();
                textBox2.DataBindings.Add(new Binding("Text", printersBindingSource, "invent_number", true));
            }
            else
            {
                comboBox3.DataSource = cartrigesBindingSource;
                comboBox3.DisplayMember = "cartridge_model";
                textBox2.DataBindings.Clear();
                textBox2.DataBindings.Add(new Binding("Text", cartrigesBindingSource, "cartridge_number", true));
            }
            //dataGridView1[0, 0].Value = comboBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = comboBox2.Text;
                dataGridView1.Rows[n].Cells[1].Value = comboBox3.Text;
                dataGridView1.Rows[n].Cells[2].Value = textBox2.Text;
                label5.Text = dataGridView1.RowCount.ToString();
            }
            else
            {
                MessageBox.Show("Не заполнено поле № Акта:","Внимание",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    label5.Text = dataGridView1.RowCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

                button1.Visible = button2.Visible = button3.Visible = button4.Visible = button5.Visible = true;
                this.printersTableAdapter.Fill(this.baseDataSet.printers);

                this.cartrigesTableAdapter.Fill(this.baseDataSet.cartriges);

                this.typeTableAdapter.Fill(this.baseDataSet.type);

                this._nameFIOTableAdapter.Fill(this.baseDataSet._nameFIO);

                comboBox1.DataSource = nameFIOBindingSource;
                comboBox1.DisplayMember = "fio_full";
                comboBox2.DataSource = typeBindingSource1;
                comboBox2.DisplayMember = "name_type";

                DGV_Load();
          
            
            
        }

        private void acts_FormClosing(object sender, FormClosingEventArgs e)
        {
            comboBox2.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tempAndCopy();
            SearchAndReplace(Application.StartupPath + "\\temp\\template_akt.docx");
            ApplWord(Application.StartupPath + "\\temp\\template_akt.docx");
            
        }

        public void tempAndCopy()
        {
            try
            {
                if (!Directory.Exists(Application.StartupPath + "\\temp"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\temp");
                }
                if (Directory.Exists(Application.StartupPath + "\\template"))
                {
                    File.Copy(Application.StartupPath + "\\template\\template_akt.docx", Application.StartupPath + "\\temp\\template_akt.docx", true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void ApplWord(string doclink)
        {
            object FileName = doclink;
            int columns = dataGridView1.Columns.Count;
            int rows = dataGridView1.Rows.Count;            
            Word.Application word = new Word.Application();            
            Word.Document doc = null;            
            object missing = System.Type.Missing;
            object readOnly = false;
            object isVisible = false;            
            word.Visible = true;
            doc = word.Documents.Open(ref FileName, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing);
            doc.Activate();            
            Word.Find o_Find = word.Selection.Find;
            Word.Selection o_Sel = word.Selection;
            o_Find.ClearFormatting();
            o_Find.Replacement.ClearFormatting();
            o_Find.Text = "Table";
            o_Find.Execute(FindText: Type.Missing,
                MatchCase: false,
                MatchWholeWord: false,
                MatchWildcards: false,
                MatchSoundsLike: Type.Missing,
                MatchAllWordForms: false,
                Forward: true,
                Wrap: Type.Missing,
                Format: false,
                ReplaceWith: Type.Missing, Replace: Type.Missing);            
            o_Sel.Delete();
            Word.Range range = word.Selection.Range;
            Object behiavor = Word.WdDefaultTableBehavior.wdWord9TableBehavior;
            Object autoFitBehiavor = Word.WdAutoFitBehavior.wdAutoFitFixed;            
            doc.Tables.Add(range, rows + 1, columns, behiavor, autoFitBehiavor);
            ////Меняем стили созданных таблиц
            Object style = "Сетка таблицы";
            doc.Tables[3].set_Style(ref style);
            Object applystyle = true;
            doc.Tables[3].set_Style(ref style);
            doc.Tables[3].ApplyStyleFirstColumn = true;
            doc.Tables[3].ApplyStyleHeadingRows = true;
            doc.Tables[3].ApplyStyleLastRow = false;
            doc.Tables[3].ApplyStyleLastColumn = false;
            doc.Tables[3].Cell(1, 1).Range.Text = "Наименование ценности";
            doc.Tables[3].Cell(1, 2).Range.Text = "Модель";
            doc.Tables[3].Cell(1, 3).Range.Text = "Инвентарный номер";
            //задаём ширину колонок и высоту строк
            doc.Tables[3].Columns.PreferredWidthType = Microsoft.Office.Interop.Word.WdPreferredWidthType.wdPreferredWidthAuto;
            doc.Tables[3].Columns[1].SetWidth(150f, Microsoft.Office.Interop.Word.WdRulerStyle.wdAdjustNone);
            doc.Tables[3].Columns[2].SetWidth(150f, Microsoft.Office.Interop.Word.WdRulerStyle.wdAdjustNone);
            doc.Tables[3].Columns[3].SetWidth(150f, Microsoft.Office.Interop.Word.WdRulerStyle.wdAdjustNone);
            doc.Tables[3].Rows[1].SetHeight(20f, Microsoft.Office.Interop.Word.WdRowHeightRule.wdRowHeightExactly);
            doc.Tables[3].Rows.Alignment = Microsoft.Office.Interop.Word.WdRowAlignment.wdAlignRowLeft;
            doc.Tables[3].Range.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    doc.Tables[3].Cell(i + 2, j + 1).Range.Text = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
        }

        public void SearchAndReplace(string document)
        {
            string date_day = DTPicker.Value.ToString("dd");
            string date_month = DTPicker.Value.ToString("MM");
            string date_year = DTPicker.Value.ToString("yyyy");
            string FioFill = comboBox1.Text;
            string num_acts = textBox1.Text;
            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(document, true))
            {
                string docText = null;
                using (StreamReader sr = new StreamReader(wordDoc.MainDocumentPart.GetStream()))
                {
                    docText = sr.ReadToEnd();
                }

                Regex reg_day = new Regex("day");
                docText = reg_day.Replace(docText, date_day);
                Regex reg_month = new Regex("month");
                docText = reg_month.Replace(docText, date_month);
                Regex reg_year = new Regex("age");
                docText = reg_year.Replace(docText, date_year);
                Regex reg_FioFill = new Regex("FioFill");
                docText = reg_FioFill.Replace(docText, FioFill);
                Regex reg_num = new Regex("AKT");
                docText = reg_num.Replace(docText, num_acts);

                using (StreamWriter sw = new StreamWriter(wordDoc.MainDocumentPart.GetStream(FileMode.Create)))
                {
                    sw.Write(docText);
                    sw.Close();
                }
                wordDoc.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                string acts = dataGridView2.Rows[i].Cells[2].Value.ToString();
                if (textBox1.Text != acts)
                {
                }
                else
                {
                    MessageBox.Show("Акт с таким номером существует!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\base.accdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            string fio = comboBox1.Text;
            int akt = Convert.ToInt32(textBox1.Text);
            string _date = DTPicker.Value.ToString("dd.MM.yyyy"); ;
            string num_count = label5.Text;
            string command = "INSERT INTO tbl_akts(_date, act_number, value_name, model, invent_number, creater, numOfrec) values (@_date, @act_number, @value_name, @model, @invent_number, @creater, @numOfrec)";
            string command1 = "INSERT INTO _akts(creater,act_number,_date,numOfrec) values (@creater,@act_number,@_date,@numOfrec)";
            OleDbCommand myoledbcommand = new OleDbCommand(command, myOleDbConnection);
            OleDbCommand myoledbcommand1 = new OleDbCommand(command1, myOleDbConnection);
            
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                //DataGridViewCell vn = dataGridView1.Rows[i].Cells[0];
                //string value_name=vn.Value.ToString();
                //DataGridViewCell m = dataGridView1.Rows[i].Cells[1];
                //string model = m.Value.ToString();
                //DataGridViewCell i_n = dataGridView1.Rows[i].Cells[2];
                //string invent_number = i_n.Value.ToString();

                string value_name = dataGridView1.Rows[i].Cells[0].Value.ToString();
                string model = dataGridView1.Rows[i].Cells[1].Value.ToString();
                string invent_number = dataGridView1.Rows[i].Cells[2].Value.ToString();

                myoledbcommand.Parameters.Add("@_date", OleDbType.Char, 8);
                myoledbcommand.Parameters["@_date"].Value = _date;

                myoledbcommand.Parameters.Add("@act_number", OleDbType.Integer, 5);
                myoledbcommand.Parameters["@act_number"].Value = akt;

                myoledbcommand.Parameters.Add("@value_name", OleDbType.Char, 20);
                myoledbcommand.Parameters["@value_name"].Value = value_name;

                myoledbcommand.Parameters.Add("@model", OleDbType.Char, 30);
                myoledbcommand.Parameters["@model"].Value = model;
                
                myoledbcommand.Parameters.Add("@invent_number", OleDbType.Char, 30);
                myoledbcommand.Parameters["@invent_number"].Value = invent_number;
                                                                
                myoledbcommand.Parameters.Add("@creater", OleDbType.Char, 50);
                myoledbcommand.Parameters["@creater"].Value = fio;
                                                               
                myoledbcommand.Parameters.Add("@numOfrec", OleDbType.Integer, 5);
                myoledbcommand.Parameters["@numOfrec"].Value = num_count;

                myOleDbConnection.Open();
                myoledbcommand.ExecuteNonQuery();
                myOleDbConnection.Close();
            }
                        
            myoledbcommand1.Parameters.Add("@creater", OleDbType.VarChar, 50);
            myoledbcommand1.Parameters["@creater"].Value = fio;

            myoledbcommand1.Parameters.Add("@act_number", OleDbType.Integer, 50);
            myoledbcommand1.Parameters["@act_number"].Value = akt;

            myoledbcommand1.Parameters.Add("@_date", OleDbType.VarChar, 50);
            myoledbcommand1.Parameters["@_date"].Value = _date;

            myoledbcommand1.Parameters.Add("@numOfrec", OleDbType.VarChar, 50);
            myoledbcommand1.Parameters["@numOfrec"].Value = num_count;

            myOleDbConnection.Open();
            myoledbcommand1.ExecuteNonQuery();
            myOleDbConnection.Close();
            DGV_Load();
            dataGridView1.Rows.Clear();
            label5.Text = "-";
                        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Visible = button2.Visible = button3.Visible = button4.Visible = button6.Visible = false;
            string point = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            int year = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value.ToString().Substring(6,4));
            int month = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value.ToString().Substring(3, 2));
            int day = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value.ToString().Substring(0, 2));
                        
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\base.accdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbDataAdapter adapter = new OleDbDataAdapter();

            myOleDbConnection.Open();
            OleDbCommand command = new OleDbCommand("SELECT value_name, model, invent_number FROM tbl_akts WHERE act_number = '"+point+"' ", myOleDbConnection);
            //OleDbCommand command = new OleDbCommand("SELECT value_name, model, invent_number FROM tbl_akts WHERE tbl_akts._date > 0 ", myOleDbConnection);
            myOleDbConnection.Close();

            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            adapter.Update(dataSet);
            dataGridView1.Columns["value_name"].DataPropertyName = "value_name";
            dataGridView1.Columns["model"].DataPropertyName = "model";
            dataGridView1.Columns["invent_number"].DataPropertyName = "invent_number";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            label5.Text = dataGridView1.RowCount.ToString();
            comboBox2.Enabled = comboBox3.Enabled = textBox2.Enabled = false;
            textBox1.Text = point;
            DTPicker.Value = new DateTime(year,month,day,0,0,0);
        }              

        public void WordDoc(string getfilename)
        {                        
            object FileName = getfilename;
            
            //Create word Application Object
            Word.Application word = new Word.Application();

            //Create word document Object
            Word.Document doc = null;

            //Create word Missing Object
            object missing = System.Type.Missing;

            object readOnly = false;
            object isVisible = false;
            // make visible Word application
            word.Visible = true;

            try
            {
                doc = word.Documents.Open(ref FileName, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing);
                doc.Activate();
                //foreach (DataGridViewRow rows in dataGridView1.SelectedRows)
                var orderedRows = from DataGridViewRow rows in dataGridView1.Rows
                                  orderby rows.Index
                                  select rows;

                foreach (DataGridViewRow rows in orderedRows)
                {
                    string item0 = rows.Cells[0].Value.ToString();
                    string item1 = rows.Cells[1].Value.ToString();
                    string item2 = rows.Cells[2].Value.ToString();
                    //string item3 = rows.Cells[3].Value.ToString();
                    //string item4 = rows.Cells[4].Value.ToString();
                    //string item5 = rows.Cells[5].Value.ToString();
                    //string item6 = rows.Cells[6].Value.ToString();
                    //string item7 = rows.Cells[7].Value.ToString();
                    //string item8 = rows.Cells[8].Value.ToString();
                    //string item9 = rows.Cells[9].Value.ToString();
                    //string item10 = rows.Cells[10].Value.ToString();
                    //string item11 = rows.Cells[11].Value.ToString();
                    //string item12 = rows.Cells[12].Value.ToString();

                    this.FindAndReplace(word, "{0}", item0);
                    this.FindAndReplace(word, "{1}", item1);
                    this.FindAndReplace(word, "{2}", item2);
                    //this.FindAndReplace(word, "!2!", item3);
                    //this.FindAndReplace(word, "!3!", item4);
                    //this.FindAndReplace(word, "!4!", item5);
                    //this.FindAndReplace(word, "!5!", item6);
                    //this.FindAndReplace(word, "!6!", item7);
                    //this.FindAndReplace(word, "!7!", item8);
                    //this.FindAndReplace(word, "!8!", item9);
                    //this.FindAndReplace(word, "!9!", item10);
                    //this.FindAndReplace(word, "!10!", item11);
                    //this.FindAndReplace(word, "!11!", item12);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }



        private void FindAndReplace(Word.Application word, object findText, object replaceText)
        {
            word.Selection.Find.ClearFormatting();
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = true;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 1;
            object wrap = 2;

            word.Selection.Find.Execute(ref findText, ref matchCase,
            ref matchWholeWord, ref matchWildCards, ref matchSoundsLike,
            ref matchAllWordForms, ref forward, ref wrap, ref format,
            ref replaceText, ref replace, ref matchKashida,
            ref matchDiacritics,
            ref matchAlefHamza, ref matchControl);
        }       
    }
       
}
