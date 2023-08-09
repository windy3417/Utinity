using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility.Sql;

namespace Utility.DataGridViewUI

{
  public  class DataGridViewRowsAssociateChoose
    {


        #region vary


        DataTable _dgvDetailDataSource;
       
                  
        #endregion

        /// <summary>
        /// add data to or  remove data from dgvDetail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DgvHead_CellContentClick<TEntity>( DataGridViewCellEventArgs e, DataGridView _dgvHeader, DataGridView _dgvDetail,
                                                       string _voucherIdHeaderColumnName, string _voucherIdDetailColumnName, List<TEntity> chooseData  )
        {

            // 判断是否点击了DataGridViewCheckBoxColumn列
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)

            {
             
                var cellValue = _dgvHeader.Rows[e.RowIndex].Cells[0].Value;

                #region add rows

                if (cellValue is null || cellValue is false)
                {
                    _dgvHeader.Rows[e.RowIndex].Cells[0].Value = true;


                    #region bind data

                    //add rows to dataGridView first
                    if (_dgvDetail.Rows.Count == 0)

                    {
                        this._dgvDetailDataSource = Utility.Common.CustomLINQtoDataSetMethods.CopyToDataTable(chooseData);
                        _dgvDetail.DataSource = _dgvDetailDataSource;

                    }

                    else
                    {

                        //append rows to datagridview

                        DataTable addDataToExistDataTable = Utility.Common.CustomLINQtoDataSetMethods.CopyToDataTable(chooseData);

                        foreach (DataRow item in addDataToExistDataTable.Rows)
                        {
                            _dgvDetailDataSource.ImportRow(item);

                        }
                    }

                    #endregion

                }
                #endregion


                #region remove rows
                else
                {
                    if (_dgvHeader.Rows[e.RowIndex].Cells[0].Value is true)
                    {
                        _dgvHeader.Rows[e.RowIndex].Cells[0].Value = false;
                        string voucherNo = _dgvHeader.Rows[e.RowIndex].Cells[_voucherIdHeaderColumnName].Value.ToString();
                        var rowsToRemove = this._dgvDetailDataSource.Select($"{_voucherIdDetailColumnName} = '{voucherNo}'");

                        foreach (DataRow rowToRemove in rowsToRemove)
                        {
                            _dgvDetailDataSource.Rows.Remove(rowToRemove);
                        }

                    }

                }

                #endregion


            }



        }


    }
}
