using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Auth;


namespace WindowsFormsAppOpenCV
{
    public partial class LoginFirebaseForm : Form
    {
        public LoginFirebaseForm()
        {
            InitializeComponent();
        }

        public string _username;
        public string _pass;
        // tk test: thanhtungct1201@gmail.com
        // pass: 123456789
        private void btn_login_Click(object sender, EventArgs e)
        {
            _username = tbt_Username.Text;
            _pass = tbt_Password.Text;
            try
            {
                var ap = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyBint0HnG0oPIaVyBD9meH5tuIITkF2WOo"));
                Task<FirebaseAuthLink> auth = ap.SignInWithEmailAndPasswordAsync(_username, _pass);
                
                
                MessageBox.Show("Log in is successful!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error:" + ex.ToString());
            }
        }
    }
}
