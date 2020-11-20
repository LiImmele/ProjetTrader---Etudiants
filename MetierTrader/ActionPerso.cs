using System;
using System.Collections.Generic;
using System.Text;

namespace MetierTrader
{
    public class ActionPerso
    {
        private int prixAchat;
        private int quantite;
        private int total;
        private string nomAction;
        private int numAction;
        private List<Action> lesActions;
        

        public ActionPerso(int unprixAchat, int uneQuantite, int unTotal, string unNom, int unNum)
        {
            PrixAchat = unprixAchat;
            Quantite = uneQuantite;
            Total = unTotal;
            NomAction = unNom;
            NumAction = unNum;
            LesActions = new List<Action>();
        }
        
        public int PrixAchat { get => prixAchat; set => prixAchat = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        public int Total { get => total; set => total = value; }
        public string NomAction { get => nomAction; set => nomAction = value; }
        public int NumAction { get => numAction; set => numAction = value; }
        public List<Action> LesActions { get => lesActions; set => lesActions = value; }
    }
}
