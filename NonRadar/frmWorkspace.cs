﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace NonRadar
{
    public partial class frmWorkspace : Form
    {
        private List<Aircraft> acList;
        private Deserializer deserializer;

        public frmWorkspace()
        {
            InitializeComponent();

            acList = new List<Aircraft>();
            deserializer = new Deserializer();
            Airspace.Initialize();
            AircraftType.Initialize();

            Application.Idle += HandleApplicationIdle;
        }

        private void frmWorkspace_Load(object sender, EventArgs e)
        {
            deserializer.FilePath = @"D:\github\NonRadarStudyAid\Data";
            if (!deserializer.FindFiles())
            {
                MessageBox.Show("Didn't find Data Files. \nSelect manually File > Select Folder", "Files not found");
            }
            else
            {
                deserializer.LoadAirways();
                deserializer.LoadAircraft();
            }
        }

        void HandleApplicationIdle(object sender, EventArgs e)
        {
            while (IsApplicationIdle())
            {
                Update();
                Render();
            }
        }

        void Update()
        {
            for (int ndx = 0; ndx < acList.Count; ndx++)
            {
                acList[ndx].Update();
            }
        }

        void Render()
        {
            textBox1.Text = System.DateTime.Now.Second.ToString();
        }

        public struct NativeMessage
        {
            public IntPtr Handle;
            public uint Message;
            public IntPtr WParameter;
            public IntPtr LParameter;
            public uint Time;
            public Point Location;
        }

        [DllImport("user32.dll")]
        public static extern int PeekMessage(out NativeMessage message, IntPtr window, uint filterMin, uint filterMax, uint remove);
        
        bool IsApplicationIdle()
        {
            NativeMessage result;
            return PeekMessage(out result, IntPtr.Zero, (uint)0, (uint)0, (uint)0) == 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderPicker = new FolderBrowserDialog();
            FolderPicker.ShowNewFolderButton = false;            
            if (FolderPicker.ShowDialog() == DialogResult.OK)
            {
                deserializer.FilePath = FolderPicker.SelectedPath;
                if (!deserializer.FindFiles())
                {
                    MessageBox.Show("Could not find files \"Aircraft.txt\" and/or \"Airways.txt\"", "Files not found");
                }
                else
                {
                    deserializer.LoadAirways();
                    deserializer.LoadAircraft();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmMapTest(Airspace.JanLo.GetAirways()).Show();
        }

    }
}
