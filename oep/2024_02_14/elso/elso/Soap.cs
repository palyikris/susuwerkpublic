

namespace elso
{
    
    public class Soap
    {

        // Adattagok / Fields
        private int full;
        private int portion;
        private int actual;

        // Metódusok / Methods
        public Soap(int k, int e)
        {
            full = k;
            portion = e;
            actual = 0;
            
        }
        public void Take()
        {
            actual = Math.Max(actual-portion, 0);
            actual = actual - portion > 0 ? actual - portion : 0;
        }

        public void Fill()
        {
            actual = full;

        }
    }

    
}
