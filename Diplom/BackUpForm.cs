﻿using EntityLibrary;
using Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class BackUpForm : Form
    {
        public BackUpForm()
        {
            InitializeComponent();
        }

        private void BtnCreateBackUp_Click(object sender, EventArgs e)
        {
            if (!tbFilePath.Text.Equals(string.Empty))
            {
                string datePath = DateTime.Now.ToString("ddMMyyyy");
                string path = tbFilePath.Text +"\\"+ datePath + ".bak";

                BackUpDao backUpDao = new BackUpDao(ConnectionString.ConnectionStringName);
                backUpDao.CreateBackUp(path);

                MessageBox.Show("Копия успешно создана",
                    "Информационное сообщение",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не выбран путь для создания резервной копии",
                    "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void BtnRestoreDB_Click(object sender, EventArgs e)
        {
            BackUpDao backUpDao = new BackUpDao(ConnectionString.ConnectionStringName);
            backUpDao.RestoreDataBase(tbRestoreFileName.Text);
        }

        private void BtnChooseBackUpDirectory_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    tbFilePath.Text = dialog.SelectedPath.ToString();
                }
            }
        }

        private void BtnChooseRestoreFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbRestoreFileName.Text = openFileDialog1.FileName.ToString();
            }
        }
    }
}
