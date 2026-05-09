namespace _05_IntroToOOP
{
    //private
    //protected
    //public
    //internal
    //protected internal

    partial class Point
    {
        public void setX(int newX)
        {
            if (newX > 0)
                this.x = newX;
            else
                this.x = 0;
        }
        public void setY(int newY)
        {
            if (newY > 0)
                this.y = newY;
            else
                this.y = 0;
        }
        public int getX() { return this.x; }
        public int getY() { return this.y; }
    }
}
