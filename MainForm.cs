/*
 * Created by SharpDevelop.
 * User: egger
 * Date: 02.06.2026
 * Time: 12:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace snake_gp
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		Graphics grafik;
		Random zo = new Random();
		Rectangle auto = new Rectangle(50,50,100,50);
		Pen stiftauto = new Pen(Color.White);
		Rectangle Diesel;
		Pen diesel = new Pen(Color.White);
		Image DIESEL = Image.FromFile("Benzinkanister.png");
		Image AUTO = Image.FromFile("Formel1.png");
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void PictureBox1Paint(object sender, PaintEventArgs e)
		{
			 grafik = e.Graphics;

			   
			    grafik.DrawRectangle(stiftauto, auto);
			
			    
			    grafik.DrawImage(AUTO, auto);
			
			    
			    grafik.DrawRectangle(diesel, Diesel);
			
			    
			    grafik.DrawImage(DIESEL, Diesel);
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			Diesel = new Rectangle(zo.Next(50,500),zo.Next(50,500),25,35);
		}
	}
}
