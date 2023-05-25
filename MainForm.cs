using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms ;
using Microsoft.Win32;
using System.IO ;
using System.Text;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Table;


namespace CheckList
{

	public partial class MainForm : Form
	{
		public string outputFile;
		public static List<String> List1CC = new List<String>();
		public static List<String> SheetList = new List<String>();
		
		
		public MainForm()
		{

			InitializeComponent();
			

		}
		void OpnPrtClick(object sender, EventArgs e)
		{
			OpenFileDialog OpenFileDialog = new OpenFileDialog();
			OpenFileDialog.Filter = "XLSX files(*.xlsx)|*.xlsx";
			OpenFileDialog.ShowDialog();
			outputFile = OpenFileDialog.FileName;
			
			PartList.Items.Clear();
			
			if (File.Exists(outputFile)) 
			{
			 PartPath.Text = outputFile;
			 FileInfo existingFile = new FileInfo(outputFile);
			
			 using (ExcelPackage package = new ExcelPackage(existingFile))
    		 {
        	  int count = package.Workbook.Worksheets.Count;
        	  for (int i = 0; i < count; i++) 
        	  {
        	 	PartList.Items.Add(package.Workbook.Worksheets.ElementAt(i).Name);
        	  }
			 }
			 
    		}
		
			
	
		}
		void Add1CClick(object sender, EventArgs e)
		{
			OpenFileDialog OpenFileDialog = new OpenFileDialog();
			OpenFileDialog.Filter = "XLSX files(*.xlsx)|*.xlsx";
			OpenFileDialog.ShowDialog();
			string File1C = OpenFileDialog.FileName;
			
			if (File.Exists(File1C)) 
			{
				if (!List1C.Items.Contains(File1C)) 
				{
				
					List1C.Items.Add(File1C);
				
				}
    		}
			
	
		}
		void Dell1CClick(object sender, EventArgs e)
		{
			
			List1C.Items.Remove( List1C.SelectedItem );
	
		}
		void CompareClick(object sender, EventArgs e)
		{
			foreach (var element in List1C.Items) 
			{
				List1CC.Add(element.ToString());
			}
			
			for (int i = 0; i < PartList.Items.Count; i++) 
			{
				if (PartList.GetItemChecked(i) )
				{
					SheetList.Add(PartList.Items[i].ToString());
				}
				
				
			}
			
			
			
			
			Excel ExcelExp = new Excel();
			ExcelExp.ExcelStart(List1CC , SheetList, PartPath.Text );
			
		}
	}
}
