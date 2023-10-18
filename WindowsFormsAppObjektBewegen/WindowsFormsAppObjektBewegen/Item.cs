using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppObjektBewegen
{
    public class Item
    {

        private int speed;
        private Control myControl;
        public delegate void MaxHoehe();
        public MaxHoehe OnMaxHoehe = null;

        public Item(int speed)
        {
            this.speed = speed;
        }

        public int Speed { get => speed; set => speed = value; }
        public Control MyControl { get => myControl; set => myControl = value; }

        public void MoveUp()
        {
            if (!(myControl.Top - speed <= 0))
            {
                myControl.Top -= speed;
            }
            else
            {
                if(OnMaxHoehe != null)
                {
                    OnMaxHoehe();
                }
            }
        }
    }
}
