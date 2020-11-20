using MySql.Data.MySqlClient;
using System;
using MetierTrader;
using System.Collections.Generic;

namespace GestionnaireBDD
{
    public class GstBdd
    {
        private MySqlConnection cnx;
        private MySqlCommand cmd;
        private MySqlDataReader dr;

        // Constructeur
        public GstBdd()
        {
            string chaine = "Server=localhost;Database=bourse;Uid=root;Pwd=";
            cnx = new MySqlConnection(chaine);
            cnx.Open();
        }

        public List<Trader> getAllTraders()
        {
            List<Trader> mesTradeurs = new List<Trader>();
            cmd = new MySqlCommand("select idTrader, nomTrader from trader;", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Trader unTradeur = new Trader(Convert.ToInt16(dr[0].ToString()), dr[1].ToString());
                mesTradeurs.Add(unTradeur);
            }
            dr.Close();
            return mesTradeurs;
        }
        public List<ActionPerso> getAllActionsByTrader(int numTrader)
        {
            List<ActionPerso> mesActionsPerso = new List<ActionPerso>();
            cmd = new MySqlCommand("SELECT numAction, quantite FROM acheter INNER JOIN trader ON acheter.numAction = trader.idTrader;", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ActionPerso uneActionPerso = new ActionPerso(Convert.ToInt16(dr[0].ToString()), dr[1].ToString());
                mesActionsPerso.Add(uneActionPerso);
            }
            dr.Close();
            return mesActionsPerso;
        }

        public List<MetierTrader.Action> getAllActionsNonPossedees(int numTrader)
        {
            List<MetierTrader.Action> mesMetierTrader = new List<MetierTrader.Action>();
            cmd = new MySqlCommand("");
            return null;
        }

        public void SupprimerActionAcheter(int numAction, int numTrader)
        {
            cmd = new MySqlCommand("delete from acheter where 'id' =(" +numAction+ " , '"+ numTrader + "')", cnx);
            cmd.ExecuteNonQuery();
        }

        public void UpdateQuantite(int numAction, int numTrader, int quantite)
        {
            cmd = new MySqlCommand("select count(*) from acheter where 'prixAchat'= (" + numAction + ", " + numTrader + ",'" + quantite + "')", cnx);
        }

        public double getCoursReel(int numAction)
        {
            double coursReel;
            cmd = new MySqlCommand("select coursReel from action where coursReel = "+ numAction,cnx);
            return 0;
        }
        public void AcheterAction(int numAction, int numTrader, double prix, int quantite)
        {
            
        }
        public double getTotalPortefeuille(int numTrader)
        {
            cmd = new MySqlCommand("SELECT sum(prixAchat + quantite) FROM acheter;", cnx);
            return 0;
        }
    }
}
