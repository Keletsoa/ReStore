
private void loadUser(string userName)
        {
            string sql = @"SELECT FirstName, LastName, UserId FROM UserLogins WHERE UserName = @UserName";

            using (SD._con = new SqlConnection(SD._conString))
            {
                using (SD._cmd = new SqlCommand(sql))
                {
                    SD._cmd.CommandType = CommandType.Text;
                    SD._cmd.Parameters.AddWithValue("@UserName", userName);
                    SD._cmd.Connection = SD._con;
                    SD._con.Open();
                    SD._dr = SD._cmd.ExecuteReader();

                    while (SD._dr.Read())
                    {

                        txtFirstName.Text = SD._dr[0].ToString();
                        txtLastName.Text = SD._dr[1].ToString();
                        txtLoginId.Text = SD._dr[2].ToString();

                        txtFirstName.ReadOnly = true;
                        txtLastName.ReadOnly = true;
                       
                    }


                }
            }
        }
