
try
            {
                using (SD._con = new SqlConnection(SD._conString))
                {
                    using (SD._cmd = new SqlCommand("spSaveAthletePersonal", SD._con))
                    {
                        SD._cmd.CommandType = CommandType.StoredProcedure;
                        SD._cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                        SD._cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);

                        if (ddlCountry.SelectedValue == "3")
                        {
                            SD._cmd.Parameters.AddWithValue("@IdNumber", idnumber.Value);
                            SD._cmd.Parameters.AddWithValue("@PassportNumber", "");
                        }
                        else
                        {
                            SD._cmd.Parameters.AddWithValue("@IdNumber", "");
                            SD._cmd.Parameters.AddWithValue("@PassportNumber", txtPassportNumber.Text);
                        }

                        SD._cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                        SD._cmd.Parameters.AddWithValue("@Gender", txtGender.Text);

                        if (ddlScholar.SelectedIndex == 1)
                        {
                            SD._cmd.Parameters.AddWithValue("@School", txtSchool.Text);
                            SD._cmd.Parameters.AddWithValue("@Grade", txtGrade.Text);
                        }
                        else
                        {
                            SD._cmd.Parameters.AddWithValue("@School", "");
                            SD._cmd.Parameters.AddWithValue("@Grade", "");
                        }

                        SD._cmd.Parameters.AddWithValue("@ContactDetails", txtContact.Text);
                        SD._cmd.Parameters.AddWithValue("@RegionId", ddlRegion.SelectedValue);
                        SD._cmd.Parameters.AddWithValue("@RaceId", ddlRace.SelectedValue);
                        SD._cmd.Parameters.AddWithValue("@CountryId", ddlCountry.SelectedValue);
                        SD._cmd.Parameters.AddWithValue("@UserLoginId", txtLoginId.Text);
                        SD._cmd.Parameters.AddWithValue("@DOB", txtDOB.Text);
                        SD._con.Open();
                        SD._cmd.ExecuteNonQuery();

                        SD._con.Close();
                    }
                }
