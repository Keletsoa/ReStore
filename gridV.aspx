<asp:GridView ID="gvSupplierDocs" runat="server" AutoGenerateColumns="false" OnRowDataBound="gvSupplierDocs_RowDataBound"
                                DataKeyNames="Id" PageSize="5" AllowPaging="true" OnPageIndexChanging="gvSupplierDocs_PageIndexChanging"
                                OnRowDeleting="gvSupplierDocs_RowDeleting" OnRowCancelingEdit="gvSupplierDocs_RowCancelingEdit"
                                CssClass="table table-bordered table-condensed table-responsive table-hover"
                                EmptyDataText="No records has been added.">
                                <Columns>
                                    <asp:TemplateField HeaderText="File Name">
                                        <ItemTemplate>
                                            <asp:Label ID="lblFileName" Text='<%# Eval ("Name") %>' runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderText="View">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkDownloadSuppDoc" runat="server" Text="View" OnClick="lnkDownloadSuppDoc_Click"
                                                CommandArgument='<%# Eval("Id") %>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
