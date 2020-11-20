using System;
using System.Collections.Generic;
using System.Text;

namespace MetierTrader
{
    public class ActionPerso
    {
        private int numActionPerso;
        private string nomActionPerso;
        private List<Action> lesActions;

        public ActionPerso(int unNumPerso, string unNomPerso)
        {
            NumActionPerso = unNumPerso;
            NomActionPerso = unNomPerso;
            LesActions = new List<Action>();
        }

        public int NumActionPerso { get => numActionPerso; set => numActionPerso = value; }
        public string NomActionPerso { get => nomActionPerso; set => nomActionPerso = value; }
        public List<Action> LesActions { get => lesActions; set => lesActions = value; }
    }
}
