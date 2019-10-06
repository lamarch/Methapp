using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methanisation
{
    static class DGW_util
    {
        public static void RemoveRow(DataGridViewRow row, DataGridView dataGridView)
        {
            if (!row.IsNewRow && dataGridView.Rows.Contains(row))
            {
                dataGridView.Rows.Remove(row);
            }
            else
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = null;
                }
            }
            return;
        }

        public static void RemoveRow(DataGridViewCell cell, DataGridView dataGridView)
        {
            if (cell == null)
                return;

            RemoveRow(cell.OwningRow, dataGridView);
            return;
        }

        public static void RemoveRow(DataGridView dataGridView)
        {
            if(dataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    RemoveRow(row, dataGridView);
                }
                return;
            }
            
            if(dataGridView.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in dataGridView.SelectedCells)
                {
                    RemoveRow(cell, dataGridView);
                }
                return;
            }
        }

        public static void ClearCell(DataGridViewCell cell)
        {
            if (cell != null)
                cell.Value = null;
            return;
        }

        public static void SetCell(DataGridViewCell cell, object value)
        {
            if (cell != null)
                cell.Value = value.ToString();
            return;
        }

        public static void InitRows(int count, DataGridView dataGridView)
        {

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    dataGridView.Rows.Remove(row);
                }
            }

            if (dataGridView.Rows.Count == count)
            {
                if (Debug.RowDebug)
                    Debug.Log("Cpt rows (==) -- r#" + dataGridView.Rows.Count + " :: f#" + count);

                return;
            }
            else if (dataGridView.Rows.Count > count)
            {
                if (Debug.RowDebug)
                    Debug.Log("Cpt rows (>) -- r#" + dataGridView.Rows.Count + " :: f#" + count);

                return;
            }
            else if (dataGridView.Rows.Count < count)
            {
                if (Debug.RowDebug)
                    Debug.Log("Cpt rows (<) -- r#" + dataGridView.Rows.Count + " :: f#" + count);

                for (int i = dataGridView.Rows.Count; i < count; i++)
                {
                    if (Debug.RowDebug)
                        Debug.Log("rows added (" + i + ") -- r#" + dataGridView.Rows.Count + " :: f#" + count + " -> ");

                    dataGridView.Rows.Add(new DataGridViewRow());
                }
            }
            else
            {
                throw new Exception("Erreur dans le comptage des colonnes !");
            }
        }

        public static bool CompareDGWData(DataGridView d1, DataGridView d2)
        {
            //si ils n'ont pas le meme nombre de colonne alors ils sont forcément différents
            if (d1.Rows.Count != d2.Rows.Count)
            {
                return false;
            }
            Debug.MsgInfo("CDGWD - d1.r.count = " + d1.Rows.Count + " d2.r.count = " + d2.Rows.Count);

            for (int i = 0; i < d1.Rows.Count; i++)
            {
                //si ils n'ont pas le meme nombre de cellules alors ils sont forcement differents
                if(d1.Rows[i].Cells.Count != d2.Rows[i].Cells.Count)
                {
                    return false;
                }
                Debug.MsgInfo("CDGWD - d1.r[i].c.count = " + d1.Rows[i].Cells.Count + " d2.r[i].c.count = " + d2.Rows[i].Cells.Count);

                for (int j = 0; j < d1.Rows[i].Cells.Count; j++)
                {
                    //si la valeur des cellules est différentes alors ils sont forcément différents
                    if(d1.Rows[i].Cells[j].Value != d2.Rows[i].Cells[j].Value)
                    {
                        return false;
                    }
                    Debug.MsgInfo("CDGWD - d1.r[i].c[j].val = " + d1.Rows[i].Cells[j].Value + " d2.r[i].c[j].val = " + d2.Rows[i].Cells[j].Value);
                }
            }
            //Si il est arrivé jusque là c'est qu'ils sont pareils
            return true;

            
                
        }

        public static DataGridView CloneDGW(DataGridView dgw)
        {
            DataGridView d = new DataGridView();
            for (int i = 0; i < dgw.Columns.Count; i++)
            {
                d.Columns.Add((DataGridViewColumn)dgw.Columns[i].Clone());
            }
            for (int j = 0; j < dgw.Rows.Count; j++)
            {
                d.Rows.Add((DataGridViewRow)dgw.Rows[j].Clone());

                for (int k = 0; k < d.Rows[j].Cells.Count; k++)
                {
                    d.Rows[j].Cells[k].Value = dgw.Rows[j].Cells[k].Value;
                    //Debug.MsgInfo("val cell r " + j + " k " + k + ":  " + d.Rows[j].Cells[k].Value);
                }
            }
            return d;
        }
    }
}
