using System.Windows.Forms;

namespace GridView
{
    public partial class Converter : Form
{
        private static Converter _form2 = null;
        public Converter()
    {
        InitializeComponent();
    }
        public static Converter Instance
        {
            get
            {
                if (_form2 == null)
                {
                    _form2 = new Converter();
                }
                return _form2;

            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _form2 = null;
        }
    }

}
