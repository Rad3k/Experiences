using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rad3k_eu.admin.database;
using rad3k_eu.admin;
using rad3k_eu.order.classes;

namespace rad3k_eu.order
{
    public partial class orderAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Orders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Orders.SelectedValue != "3")
            {
                nextStep.Visible = true;
                Type.Visible = true;
                doplnInformaceLabel.Visible = true;
                doplnInformace.Visible = true;
                addData.Visible = true;
                Obchod.Visible = false;
                name.Visible = false;
                nameText.Visible = false;
                value.Visible = false;
                email.Visible = false;
                valueText.Visible = false;
                emailText.Visible = false;
                typPotionu.Visible = false;
                typZbozi.Visible = false;
                typZboziLabel.Visible = false;
                Obchod.Visible = false;
            }
            else
            {
                nextStep.Visible = false;
                Obchod.Visible = true;
                Type.Visible = true;
                doplnInformaceLabel.Visible = true;
                doplnInformace.Visible = true;
                addData.Visible = true;
                name.Visible = true;
                value.Visible = true;
                email.Visible = true;
                typPotionu.Visible = false;
                valueText.Visible = true;
                emailText.Visible = true;
                nameText.Visible = true;
                typZbozi.Visible = true;
                typZboziLabel.Visible = true;
                Obchod.Visible = true;

                name.Text = "Zadejte jméno zboží: ";
                value.Text = "Počet kusů: ";
                email.Text = "Zadejte Váš nick: ";
            }
        }

        protected void nextStep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Orders.SelectedValue == "1")
            {
                if (nextStep.SelectedValue == "1")
                {
                    name.Visible = true;
                    nameText.Visible = true;
                    value.Visible = false;
                    email.Visible = true;
                    valueText.Visible = false;
                    emailText.Visible = true;
                    typPotionu.Visible = false;
                    typZbozi.Visible = false;
                    typZboziLabel.Visible = false;
                    Obchod.Visible = false;
                    name.Text = "Zadejte jméno hry: ";
                    email.Text = "Zadejte Váš email: ";
                    UniqueValue.value = 1;
                }
                else
                {
                    name.Visible = false;
                    value.Visible = false;
                    email.Visible = true;
                    nameText.Visible = false;
                    valueText.Visible = false;
                    emailText.Visible = true;
                    typPotionu.Visible = false;
                    typZbozi.Visible = false;
                    typZboziLabel.Visible = false;
                    Obchod.Visible = false;
                    email.Text = "Zadejte Váš email: ";
                    UniqueValue.value = 2;
                }
            }
            else if (Orders.SelectedValue == "2")
            {
                if (nextStep.SelectedValue == "1")
                {
                    name.Visible = true;
                    value.Visible = true;
                    email.Visible = true;
                    nameText.Visible = true;
                    valueText.Visible = true;
                    emailText.Visible = true;
                    typPotionu.Visible = false;
                    typZbozi.Visible = false;
                    typZboziLabel.Visible = false;
                    Obchod.Visible = false;

                    name.Text = "Zadejte jméno hry: ";
                    value.Text = "Počet kusů: ";
                    email.Text = "Zadejte Váš email: ";
                    UniqueValue.value = 3;
                }
                else
                {
                    name.Visible = true;
                    value.Visible = true;
                    email.Visible = true;
                    typPotionu.Visible = true;
                    valueText.Visible = true;
                    emailText.Visible = true;
                    nameText.Visible = false;
                    typZbozi.Visible = false;
                    typZboziLabel.Visible = false;
                    Obchod.Visible = false;

                    name.Text = "Zadejte typ potionu: ";
                    value.Text = "Počet kusů: ";
                    email.Text = "Zadejte Váš nick: ";
                    UniqueValue.value = 4;
                }
            }
        }

        protected void addData_Click(object sender, EventArgs e)
        {
            transaction tran = new transaction();
            if (Orders.SelectedValue != "3")
            {
                if (tran.saveTicket(Orders.SelectedItem.Text, nextStep.SelectedItem.Text, doplnInformace.Text, typPotionu.SelectedItem.Text, nameText.Text, valueText.Text, emailText.Text).Contains("done"))
                {
                    dropDownList.Visible = false;
                    Orders.Visible = false;
                    nextStep.Visible = false;
                    Type.Visible = false;
                    doplnInformaceLabel.Visible = false;
                    doplnInformace.Visible = false;
                    addData.Visible = false;
                    name.Visible = false;
                    value.Visible = false;
                    email.Visible = false;
                    nameText.Visible = false;
                    valueText.Visible = false;
                    emailText.Visible = false;
                    typPotionu.Visible = false;
                    Obchod.Visible = false;
                    typZboziLabel.Visible = false;
                    typZbozi.Visible = false;

                    nadpis.ForeColor = System.Drawing.Color.DarkGreen;
                    nadpis.Text = "Transakce proběhla v pořádku";
                }
            }
            else
            {
                if (tran.saveBusiness(Orders.SelectedItem.Text, Obchod.SelectedItem.Text, doplnInformace.Text, typZbozi.SelectedItem.Text, nameText.Text, valueText.Text, emailText.Text).Contains("done"))
                {
                    dropDownList.Visible = false;
                    Orders.Visible = false;
                    nextStep.Visible = false;
                    Type.Visible = false;
                    doplnInformaceLabel.Visible = false;
                    doplnInformace.Visible = false;
                    addData.Visible = false;
                    name.Visible = false;
                    value.Visible = false;
                    email.Visible = false;
                    nameText.Visible = false;
                    valueText.Visible = false;
                    emailText.Visible = false;
                    typPotionu.Visible = false;
                    Obchod.Visible = false;
                    typZboziLabel.Visible = false;
                    typZbozi.Visible = false;

                    nadpis.ForeColor = System.Drawing.Color.DarkGreen;
                    nadpis.Text = "Transakce proběhla v pořádku";
                }
            }
            /*Email sEmail = new Email();
            sEmail.sendEmail(emailText.Text, "Rad3k.T@seznam.cz", Orders.SelectedItem.Text + " " + nextStep.SelectedItem.Text, doplnInformace.Text);*/
        }
    }
}