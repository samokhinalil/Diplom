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
    public partial class PositionListForm : Form
    {
        public PositionListForm()
        {
            InitializeComponent();

            dgvPositions.AutoGenerateColumns = false;
            UpdateDgvPositions();
        }

        private void UpdateDgvPositions()
        {
            dgvPositions.DataSource = null;
            dgvPositions.DataSource = PositionDao.SelectList();
        }

        private void BtnAddPosition_Click(object sender, EventArgs e)
        {
            PositionDao.Add(new Position(tbPositionName.Text));
            UpdateDgvPositions();
            tbPositionName.Clear();
        }

        private void BtnEditPosition_Click(object sender, EventArgs e)
        {
            Position position = (Position)dgvPositions.CurrentRow.DataBoundItem;
            position.PositionName = tbPositionName.Text;
            PositionDao.Edit(position);
            UpdateDgvPositions();
        }

        private void DgvPositions_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPositions.SelectedRows.Count != 0)
                tbPositionName.Text = dgvPositions.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}