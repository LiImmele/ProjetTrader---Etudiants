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
        private List<Action> lesActions;

        public ActionPerso(int unprixAchat, int uneQuantite, int unTotal)
        {
            PrixAchat = unprixAchat;
            Quantite = uneQuantite;
            Total = unTotal;
            LesActions = new List<Action>();
        }
        public List<Action> LesActions { get => lesActions; set => lesActions = value; }
        public int PrixAchat { get => prixAchat; set => prixAchat = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        public int Total { get => total; set => total = value; }
    }
}
