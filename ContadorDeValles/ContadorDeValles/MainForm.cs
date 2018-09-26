/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 9/25/2018
 * Time: 11:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ContadorDeValles
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//String [] vector={"B","B","B","S","S","B","S","S","S","S","B","B","B","B","S","S"};
			String [] vector={"S","S","B","B","B","S","B","S","B","B","S","B","S","S"};
			int valles=GetValles(vector);
			MessageBox.Show("La cantidad de valles es "+valles);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		public int GetValles(String []s ){
			int cantValles=0;
			int nivelDelMar=0;
			
			
			for (int i = 0; i < s.Length; i++) {
				if(s[i]=="S"){
					nivelDelMar++;
				}else if(s[i]=="B"){
					nivelDelMar--;
				}
				
				
				if(nivelDelMar==0 && s[i]=="S"){
					cantValles++;
				}
				
			}
			
			return cantValles;
			
		}
		
	}
}
