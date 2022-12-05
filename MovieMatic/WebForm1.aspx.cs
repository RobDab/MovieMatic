using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MovieMatic
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelSalaNord.Text = "Nessuna prenotazione";
            LabelSalaEst.Text = "Nessuna prenotazione";
            LabelSalaSud.Text = "Nessuna prenotazione";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = Name.Text;
            string lastname = Lastname.Text;
            bool ridotto = reducedTicket.Checked;
            string sala = Sala.SelectedValue;

            Ticket currentTicket = new Ticket(
                name,
                lastname,
                ridotto,
                sala
                );
            
            AddTicket(currentTicket);
            //UpdateTicketCount();

            int TicketNord = 0;
            int TicketNord_ridotto = 0;
            int TicketEst = 0;
            int TicketEst_ridotto = 0;
            int TicketSud = 0;
            int TicketSud_ridotto = 0;

            foreach (Ticket ticket in Ticket.TicketList)
            {
                switch (ticket.Sala)
                {
                    case "Nord":
                        if (TicketNord < 120)
                        {
                            TicketSud += 1;
                            if (ticket.Ridotto)
                            {
                                TicketSud_ridotto += 1;
                            }

                            if (TicketSud == 120)
                            {
                                SudSoldOut.Visible = true;
                            }

                        }
                        break;

                    case "Est":
                        if (TicketEst < 120)
                        {
                            TicketSud += 1;
                            if (ticket.Ridotto)
                            {
                                TicketSud_ridotto += 1;
                            }

                            if (TicketSud == 120)
                            {
                                SudSoldOut.Visible = true;
                            }

                        }
                        break;
                    case "Sud":
                        if (TicketSud < 3)
                        {
                            TicketSud += 1;
                            if (ticket.Ridotto)
                            {
                                TicketSud_ridotto += 1;
                            }

                            if(TicketSud == 3)
                            {
                                SudSoldOut.Visible = true;
                            }
                            
                        }
                        break;
                }
            }
            LabelSalaNord.Text = $"Disponibili {120 - TicketNord}/120 ticket. Prenotati {TicketNord_ridotto} ridotti.";
            LabelSalaEst.Text = $"Disponibili {120 - TicketEst}/120 ticket. Prenotati {TicketEst_ridotto} ridotti.";
            LabelSalaSud.Text = $"Disponibili {120 - TicketSud}/120 ticket. Prenotati {TicketSud_ridotto}  ridotti.";
            

            Name.Text = "";
            Lastname.Text = "";
            reducedTicket.Checked = false;
        }


        public static void AddTicket(Ticket ticket)
        {
            Ticket.TicketList.Add(ticket);
            
        }

        
        public static void UpdateTicketCount()
        {

            //int TicketNord = 0;
            //int TicketNord_ridotto = 0;
            //int TicketEst = 0;
            //int TicketEst_ridotto = 0;
            //int TicketSud = 0;
            //int TicketSud_ridotto = 0;

            //foreach (Ticket ticket in Ticket.TicketList)
            //{
            //    switch (ticket.Sala)
            //    {
            //        case "Nord":
            //            if (TicketNord < 120)
            //            {
            //                TicketNord += 1;
            //                if (ticket.Ridotto)
            //                {
            //                    TicketNord_ridotto += 1;
            //                }
            //                break;
            //            }
            //            else
            //            {
            //                NordSoldOut.Visible = true;
            //                break;
            //            }

            //        case "Est":
            //            if (TicketEst < 120)
            //            {
            //                TicketEst += 1;
            //                if (ticket.Ridotto)
            //                {
            //                    TicketEst_ridotto += 1;
            //                }
            //                break;
            //            }
            //            else
            //            {

            //                EstSoldOut.Visible = true;
            //                break;
            //            }
            //        case "Sud":
            //            if (TicketSud < 120)
            //            {
            //                TicketSud += 1;
            //                if (ticket.Ridotto)
            //                {
            //                    TicketSud_ridotto += 1;
            //                }
            //                break;
            //            }
            //            else
            //            {
            //                SudSoldOut.Visible = true;
            //                break;
            //            }
            //    }
            //}
            //LabelSalaNord.Text = $"Disponibili {120 - TicketNord}/120 ticket. Dei quali {TicketNord_ridotto} ridotti.";
            //LabelSalaEst.Text = $"Disponibili {120 - TicketEst}/120 ticket. Dei quali {TicketEst_ridotto} ridotti.";
            //LabelSalaSud.Text = $"Disponibili {120 - TicketSud}/120 ticket. Dei quali  {TicketSud_ridotto}  ridotti.";
            //Label1.Text = "ciao";
        }
        public class Ticket
        {
            public string Name { get; set; }

            public string Lastname { get; set; }

            public bool Ridotto { get; set; }

            public string Sala { get; set; }

            public Ticket(string name, string lastname, bool ridotto, string sala)
            {
                Name = name;
                Lastname = lastname;
                Ridotto = ridotto;
                Sala = sala;

                
            }

            public static List<Ticket> TicketList = new List<Ticket>();

        }
    }
}