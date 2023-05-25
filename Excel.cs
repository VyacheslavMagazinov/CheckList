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

	public class Excel
	{
		public static string[] Fill1CCC = new string[3];
		public List<string[]> Fill1C = new List<string[]>();
		
		
		public void CreateStatus1C(List<String> List1C, ref List<string[]> StatRes )
		{
			string[] Tmp1C = new string[2];
			
		for (int i = 0; i < List1C.Count; i++) 
		{
			
			if (File.Exists(List1C[i]))
			{
			 FileInfo existingFile = new FileInfo(List1C[i]);
			
			 using (ExcelPackage package = new ExcelPackage(existingFile))
    		 {
			 	int b = 1;
				do
				{
					
				 Fill1CCC[0] = package.Workbook.Worksheets[1].Cells[b,5].Text;
				 Fill1CCC[1] = package.Workbook.Worksheets[1].Cells[b,9].Text;
				 
				 if (Fill1CCC[0] == "") break;
				 
				 StatRes.Add(new string[2] {Fill1CCC[0],Fill1CCC[1]});
				 
				 b++;
				}
				while (b < 1000);
			 }
			 
    		}
			
		}	
			
		}
		
		
		public void UpdateStatus1C(List<String> Sheets, List<string[]> StatRes, string PathPart )
		{
			 FileInfo existingFile = new FileInfo(PathPart);

			 using (ExcelPackage package = new ExcelPackage(existingFile))
    		 {
				foreach (string Sheet in Sheets)
				{

					foreach (string[] Stat in StatRes) 
					{
			 		 int b = 1;
					 do
					 {
					 	
					 	if (package.Workbook.Worksheets[Sheet].Cells[b,3].Text == Stat[0]) 
					 	{
					 		package.Workbook.Worksheets[Sheet].Cells[b,7].Value = Stat[1];
					 	}
					
				 	 if (package.Workbook.Worksheets[Sheet].Cells[b,3].Text == "") break;
				 	 
				 	 b++;
				 	 
					 }
					 while (b < 2000);
					 
					}
					
				}
				
				
			  package.SaveAs(new FileInfo(@PathPart));  //сохранение экселя
			 	
			 }
			
		}
		
		
		public void ExcelStart(List<String> List1C, List<String> Sheets, string PathPart)
		{
			CreateStatus1C(List1C, ref Fill1C);
			UpdateStatus1C(Sheets, Fill1C, PathPart);
//			int gfjgf = 8;
			MessageBox.Show("Сохранено");
			
			
		}
		
	}
}
