using CSharp3DExperienceClientWithRestAPI.AppEnvironment;
using CSharp3DExperienceClientWithRestAPI.My3DExperience;
using CSharp3DExperienceClientWithRestAPI.My3DExperience.JsonResponses;
using CSharp3DExperienceClientWithRestAPI.MyPlmData;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CSharp3DExperienceClientWithRestAPI
{
    public partial class MainForm : Form
    {
        /* Global Variables */
        My3DPassport myPassport = new My3DPassport();
        My3DSpace my3DSpace = new My3DSpace();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            grSecurityContext.Visible = false;
            myTabs.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Text = "***";
            btnLogin.Enabled = false;

            /* If already authenticated, logout */
            if (myPassport.UserPrefs != null)
            {
                /* Logout */
                bool res = myPassport.Logout(myPassport.MyClient);

                if (res == true)
                {
                    /* Clear User credentials */
                    myPassport.UserPrefs = null;

                    /* Update Ui */
                    myTabs.Visible = false;
                    grSecurityContext.Visible = false;
                    grLogin.Visible = true;
                    btnLogin.Text = "Connect to 3DEXPERIENCE";
                    btnLogin.Enabled = true;
                    this.Text = "CSharp3DExperienceClientWithRestAPI";
                }
                return;
            }

            /* Connect to the 3DEXPERIENCE Platform */
            myPassport.MyClient = myPassport.set_client();

            // get loging ticket
            string lt = myPassport.get_login_ticket(myPassport.MyClient);

            // redirect to 3DSpace
            myPassport.UserPrefs = myPassport.redirect_to_3DSpace(myPassport.MyClient, lt, txtUsername.Text.Trim(), txtPassword.Text.Trim(), ckRememberMe.Checked);

            // is connected?
            if (myPassport.UserPrefs != null)
            {
                // parse Scurity Context
                cmbSecurityContext.Items.Clear();
                for (int i = 0; i < myPassport.UserPrefs.collabspaces.Count; i++)
                {
                    var obj = myPassport.UserPrefs.collabspaces[i];

                    string cs1 = obj.couples[0].role.name + "." + obj.name;
                    cmbSecurityContext.Items.Add(cs1);

                    if (obj.couples.Count > 1)
                    {
                        string cs2 = obj.couples[1].role.name + "." + obj.name;
                        cmbSecurityContext.Items.Add(cs2);
                    }
                }

                // select security context
                cmbSecurityContext.Text = myPassport.UserPrefs.preferredcredentials.role.name + "." + myPassport.UserPrefs.preferredcredentials.collabspace.name;
                myPassport.SecurityContext = myPassport.UserPrefs.preferredcredentials.role.name + "." + myPassport.UserPrefs.preferredcredentials.organization.name + "." + myPassport.UserPrefs.preferredcredentials.collabspace.name;

                // set my 3dspace
                my3DSpace.myPassport = myPassport;

                // update ui
                myTabs.Visible = true;
                grSecurityContext.Visible = true;
                grLogin.Visible = false;
                btnLogin.Text = "Logout";
                btnLogin.Enabled = true;
                this.Text = "CSharp3DExperienceClientWithRestAPI - Connected with: " + myPassport.UserPrefs.name;
            } else
            {
                // error msg...
                MessageBox.Show("Doinkk! An error occured while your reading credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // login failed...
                myTabs.Visible = false;
                grSecurityContext.Visible = false;
                grLogin.Visible = true;
                btnLogin.Text = "Connect to 3DEXPERIENCE";
                btnLogin.Enabled = true;
                this.Text = "CSharp3DExperienceClientWithRestAPI";
            }
        }

        private void cmbSecurityContext_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* If selected Admin */
            if (cmbSecurityContext.SelectedIndex == cmbSecurityContext.Items.Count)
            {
                myPassport.SecurityContext = "VPLMAdmin.Company Name.Default";
                return;
            }

            /* If others, again admin :) don't do this */
            myPassport.SecurityContext = "VPLMAdmin.Company Name.Default";
        }


        private void link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /* Update State */
            string link1Name = link1.Text;
            link1.Text = "1 - Please wait...";
            this.Enabled = false;

            /* Search in 3DEXPERIENCE */
            XCADSearchResult result = my3DSpace.Search_CADCollaboration("[ds6w:cadMaster]:solidworks and [ds6w:isLastRevision]:true"); //[ds6w:isLastRevision]:true


            /* Convert to ERP, MES common Data */
            PLMExportData commonList = new PLMExportData();
            commonList.totalItem = result.totalItems;
            commonList.items = new List<ExportInfo>(commonList.totalItem);

            for (int i = 0; i < result.totalItems; i++)
            {
                /* Next item */
                var curRes = result.member[i];

                /* Convert each data one by one */
                ExportInfo curObj = new ExportInfo() {
                    id = curRes.id,
                    creation = curRes.created,
                    description = curRes.description,
                    maturity = curRes.state,
                    modified = curRes.modified,
                    name = curRes.name,
                    owner = curRes.owner,
                    revision = curRes.revision,
                    title = curRes.title,
                    type = curRes.type,
                };

                /* Add to list */
                commonList.items.Add(curObj);
            }

            /* Update External System */
            File.WriteAllText(new ApplicationPaths().DBFolder + "\\" + new ApplicationPaths().DBName, JsonConvert.SerializeObject(commonList));


            /* Completed! */
            MessageBox.Show("Process completed successfully! " + commonList.totalItem + " item is sent to External System", "Integration" , MessageBoxButtons.OK, MessageBoxIcon.Information);

            /* Update State */
            this.Enabled = true;
            link1.Text = link1Name;
        }

        private void link2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /* Update State */
            string link2Name = link2.Text;
            link2.Text = "2 - Please wait...";
            this.Enabled = false;

            /* Search in 3DEXPERIENCE */
            XCADSearchResult result = my3DSpace.Search_CADCollaboration("*", dsxcad: "dsxcad:Drawing"); 

            /* Convert to ERP, MES common Data */
            PLMExportData commonList = new PLMExportData();
            commonList.totalItem = result.totalItems;
            commonList.items = new List<ExportInfo>(commonList.totalItem);

            for (int i = 0; i < result.totalItems; i++)
            {
                /* Next item */
                var curRes = result.member[i];

                /* Convert each data one by one */
                ExportInfo curObj = new ExportInfo()
                {
                    id = curRes.id,
                    creation = curRes.created,
                    description = curRes.description,
                    maturity = curRes.state,
                    modified = curRes.modified,
                    name = curRes.name,
                    owner = curRes.owner,
                    revision = curRes.revision,
                    title = curRes.title,
                    type = curRes.type,
                };

                /* Add to list */
                commonList.items.Add(curObj);
            }

            /* Update External System */
            File.WriteAllText(new ApplicationPaths().DBFolder + "\\" + new ApplicationPaths().DBName, JsonConvert.SerializeObject(commonList));


            /* Completed! */
            MessageBox.Show("Process completed successfully! " + result.totalItems.ToString() + " item is sent to External System", "Integration", MessageBoxButtons.OK, MessageBoxIcon.Information);


            /* Update State */
            this.Enabled = true;
            link2.Text = link2Name;
        }

        private void btnSearchEngObj_Click(object sender, EventArgs e)
        {
            string btnName = btnSearchEngObj.Text;
            btnSearchEngObj.Text = "***";
            btnSearchEngObj.Enabled = false;

            /* Search in 3DEXPERIENCE */
            XCADSearchResult resProduct = my3DSpace.Search_CADCollaboration(txtSearch.Text.Trim(), dsxcad: "dsxcad:Product");
            XCADSearchResult resParts = my3DSpace.Search_CADCollaboration(txtSearch.Text.Trim(), dsxcad: "dsxcad:Part");

            /* Update data set */
            lbTotalItem.Text = "Total Item: 0";
            lbTotalItem.Refresh();
            dataTable.Rows.Clear();

            /* For product Result */
            if (resProduct.totalItems > 0)
            {
                for (int i = 0; i < resProduct.totalItems; i++)
                {
                    var x = resProduct.member[i];
                    dataTable.Rows.Add(x.id, x.name, "Product", x.title, x.revision, x.state, x.description, x.owner, x.collabspace, x.created, x.modified);
                }
            }

            /* For part Result */
            if ( resParts.totalItems > 0)
            {
                for (int i = 0; i < resProduct.totalItems; i++)
                {
                    var y = resParts.member[i];
                    dataTable.Rows.Add(y.id, y.name, "Part", y.title, y.revision, y.state, y.description, y.owner, y.collabspace, y.created, y.modified);
                }
            }

            /* Refresh Data Table */
            lbTotalItem.Text = "Total Item: " + (resParts.totalItems + resProduct.totalItems).ToString();
            lbTotalItem.Refresh();
            dataTable.Refresh();

            btnSearchEngObj.Text = btnName;
            btnSearchEngObj.Enabled = true;
        }

        private void btnSearchDrawing_Click(object sender, EventArgs e)
        {
            string btnName = btnSearchDrawing.Text;
            btnSearchDrawing.Text = "***";
            btnSearchDrawing.Enabled = false;

            /* Search in 3DEXPERIENCE */
            XCADSearchResult resDrawing = my3DSpace.Search_CADCollaboration(txtSearch.Text.Trim(), dsxcad: "dsxcad:Drawing");

            /* Update data set */
            lbTotalItem.Text = "Total Item: 0";
            lbTotalItem.Refresh();
            dataTable.Rows.Clear();

            /* For product Result */
            if (resDrawing.totalItems > 0)
            {
                for (int i = 0; i < resDrawing.totalItems; i++)
                {
                    var x = resDrawing.member[i];
                    dataTable.Rows.Add(x.id, x.name, x.type, x.title, x.revision, x.state, x.description, x.owner, x.collabspace, x.created, x.modified);
                }
            }


            /* Refresh Data Table */
            lbTotalItem.Text = "Total Item: " + resDrawing.totalItems.ToString();
            lbTotalItem.Refresh();
            dataTable.Refresh();

            btnSearchDrawing.Text = btnName;
            btnSearchDrawing.Enabled = true;
        }

        private void linkLearn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://dspart005-eu1-partners-3dswym.3dexperience.3ds.com/community/swym:partners:DSPART005:community:7cvQNgg1RpOhxnIPvE-QPg?content=swym:partners:DSPART005:wikitree:nW8eXza3QMmvaLqV5a1c6A");
        }

        private void linkUQL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://dspart005-eu1-partners-3dswym.3dexperience.3ds.com/community/swym:partners:DSPART005:community:7cvQNgg1RpOhxnIPvE-QPg?content=swym:partners:DSPART005:wikitree:9BIPc3ipRMOwYuzCBTXLRQ");
        }

        private void linkDevelepoer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://media.3ds.com/support/documentation/developer/Cloud/en/DSDoc.htm?show=CAAiamREST/CAATciamRESTToc.htm");
        }

        private void rightClickERP_Click(object sender, EventArgs e)
        {
            /* Get selected rows */
            var rows = dataTable.SelectedRows;

            /* If is there any selected rows */
            if (rows.Count > 0)
            {
                /* Convert to ERP, MES common Data */
                PLMExportData commonList = new PLMExportData();
                commonList.totalItem = rows.Count;
                commonList.items = new List<ExportInfo>(commonList.totalItem);

                /* Convert each Item One by One */
                for (int i = 0; i < rows.Count; i++) {
                    var curRow = rows[i];

                    /* Convert each data one by one */
                    try
                    {
                        ExportInfo curObj = new ExportInfo()
                        {
                            id = curRow.Cells[0].Value.ToString(),
                            name = curRow.Cells[1].Value.ToString(),
                            type = curRow.Cells[2].Value.ToString(),
                            title = curRow.Cells[3].Value.ToString(),
                            revision = curRow.Cells[4].Value.ToString(),
                            maturity = curRow.Cells[5].Value.ToString(),
                            description = curRow.Cells[6].Value.ToString(),
                            owner = curRow.Cells[7].Value.ToString(),
                            creation = curRow.Cells[9].Value.ToString(),
                            modified = curRow.Cells[10].Value.ToString(),
                        };

                        /* Add to list */
                        commonList.items.Add(curObj);
                    } catch
                    {
                        // do nothing...
                    }
                }

                /* Update External System */
                File.WriteAllText(new ApplicationPaths().DBFolder + "\\" + new ApplicationPaths().DBName, JsonConvert.SerializeObject(commonList));


                /* Completed! */
                MessageBox.Show("Process completed successfully! " + commonList.totalItem.ToString() + " item is sent to External System", "Integration", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void rightClickMES_Click(object sender, EventArgs e)
        {
            rightClickERP_Click(sender, e);
        }
    }
}
