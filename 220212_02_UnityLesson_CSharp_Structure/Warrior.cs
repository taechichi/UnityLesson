using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220212_02_UnityLesson_CSharp_Structure
{
    // Internal 해당 프로젝트에서만 사용할 수 있는 클래스
    internal class Warrior
    {
        /*
        public int _STR;        // Strength
        public int _DEX;        // Dexterity
        public int _CON;        // Consitituion
        public int _WIS;        // Wisdom
        public int _INT;        // Intelligence
        public int _REG;        // Registance
        */

        public Stats stats;
        public void SetStats(int STR, int DEX, int CON, int WIS, int INT, int REG)
        {
            stats._STR = STR;
            stats._DEX = DEX;
            stats._WIS = WIS;
            stats._INT = INT;
            stats._REG = REG;
        }
    }   
}
