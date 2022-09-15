private void bindGrid()
        {
            string query = string.Empty;
            query = "SELECT * FROM App_SupplierDocuments WHERE UserName = @User AND eRFQId = @Id";

            try
            {
                using (SD._con = new SqlConnection(SD._conString))
                {
                    using (SD._cmd = new SqlCommand(query))
                    {
                        using (SD._adapter = new SqlDataAdapter(query, SD._con))
                        {
                            SD._cmd.Parameters.AddWithValue("@User", lblApplicationUser.Text);
                            SD._cmd.Parameters.AddWithValue("@Id", lblRfqId2.Text);
                            SD._cmd.Connection = SD._con;
                            SD._adapter.SelectCommand = SD._cmd;
                            using (var ds = new DataSet())
                            {
                                SD._adapter.Fill(ds);
                                gvSupplierDocs.DataSource = ds.Tables[0];
                                gvSupplierDocs.DataBind();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        protected void gvSupplierDocs_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //if (e.Row.RowType == DataControlRowType.DataRow)
            //{
            //    if (txtStatus.Text.Equals(SD.Approved))
            //    {
            //        ((LinkButton)e.Row.Cells[1].Controls[0]).Visible = false;
            //    }

            //}
        }
        
        protected void gvSupplierDocs_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvSupplierDocs.PageIndex = e.NewPageIndex;
            this.bindGrid();
        }

        protected void gvSupplierDocs_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int rowId = Convert.ToInt32(gvSupplierDocs.DataKeys[e.RowIndex].Values[0]);
            string qry = "DELETE FROM App_SupplierDocuments WHERE Id = @Id";
            using (SD._con = new SqlConnection(SD._conString))
            {
                using (SD._cmd = new SqlCommand(qry))
                {
                    SD._cmd.Parameters.AddWithValue("Id", rowId);
                    SD._cmd.Connection = SD._con;
                    SD._con.Open();
                    SD._cmd.ExecuteNonQuery();
                    SD._con.Close();
                }
            }

            this.bindGrid();
        }

        protected void gvSupplierDocs_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvSupplierDocs.EditIndex = -1;
            this.bindGrid();
        }
        
        protected void lnkDownloadSuppDoc_Click(object sender, EventArgs e)
        {
            int id = int.Parse((sender as LinkButton).CommandArgument);
            byte[] bytes;
            string fileName, contentType;

            using (SqlConnection con = new SqlConnection(SD._conString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT Name, Data, ContentType FROM App_SupplierDocuments WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        bytes = (byte[])sdr["Data"];
                        contentType = sdr["ContentType"].ToString();
                        fileName = sdr["Name"].ToString();
                    }
                    con.Close();
                }
            }
            Response.Clear();
            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = contentType;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);
            Response.BinaryWrite(bytes);
            Response.Flush();
            Response.End();
        }
