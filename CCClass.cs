using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClickerProject
{
    class CCClass
    {
        int m_add;
        int m_count;
        int m_upgrade = 1;
        //I've never played cookie clicker, I don't know how to do this
        public CCClass()
        {
            m_count = 0;
        }
        public void click()
        {
            if (m_upgrade == 1)
            {
                m_count++;
            }
            if (m_upgrade == 2)
            {
                m_count = m_count + 5;
            }
            if (m_upgrade == 3)
            {
                m_count = m_count + 10;
            }
        }
        public int amount(int amt)
        {
            return amt = m_count;
        }
        public int getScore()
        {
            return m_count;
        }
        public void hire(Boolean nerd, Boolean prgrmr, Boolean hckmn)
        {
            if (nerd == true) {
                Boolean money = true;
            }
            if (prgrmr == true)
            {
                Boolean money2 = true;
            }
            if (hckmn == true)
            {
                Boolean money3 = true;
            }
        }
        public void upgrade()
        {
            m_upgrade++;
        }
        public override string ToString()
        {
            return "Cookies: " + m_count;
        }
    }
}
