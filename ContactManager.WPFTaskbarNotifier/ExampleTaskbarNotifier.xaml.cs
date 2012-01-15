using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;
using WPFTaskbarNotifier;
using System.Threading;
using Logic.BusinessLogic;
using Logic;

namespace WPFTaskbarNotifierExample
{
    /// <summary>
    /// This is just a mock object to hold something of interest. 
    /// </summary>
    public class NotifyObject
    {
        public NotifyObject(string message, string title,string message2)
        {
            this.message = message;
            this.title = title;
            this.message2 = message2;
        }

        private string title;
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        private string message;
        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }
        private string message2;
        public string Message2
        {
            get { return this.message2; }
            set { this.message2 = value; }
        }
    }

    /// <summary>
    /// This is a TaskbarNotifier that contains a list of NotifyObjects to be displayed.
    /// </summary>
    public partial class ExampleTaskbarNotifier : TaskbarNotifier
    {
        PersonManager personManager = new PersonManager();
        public ExampleTaskbarNotifier()
        {
            Person actualCall = new Person();
            int ide = 9;
            bool a = personManager.Delete(ide);
            String name = actualCall.Firstname + " " + actualCall.Surname;
            //Thread t = new Thread(getPerson);
            //t.Start();
            InitializeComponent();
            this.Show();
            this.NotifyContent.Add(new NotifyObject("Details", name ,actualCall.TelephoneNumber));
            this.Notify();
            //Thread.Sleep(3000);
            
        }
       

        public void getPerson()
        {

            //this.Show();
            //this.NotifyContent.Add(new NotifyObject("test", "Stefanie"));
            //this.Notify();

            /* PersonManager p = new PersonManager();
             Person result = p.getPersonbyTelephonnumber();
               
                if(result!=null)
                {

                    //WPFTaskbarNotifier taskbarNotifier = new WPFTaskbarNotifier();
                    this.NotifyContent.Add(new NotifyObject(result.TelephoneNumber, result.Firstname + " " + result.Surname));
                    // Tell the TaskbarNotifier to open.
                    this.Notify();
                //taskbarNotifier.NotifyContent.Add(new NotifyObject(result.TelephoneNumber, result.Firstname+" "+result.Surname));
                }
                Thread.Sleep(3000);*/

        }

        private ObservableCollection<NotifyObject> notifyContent;
        /// <summary>
        /// A collection of NotifyObjects that the main window can add to.
        /// </summary>
        public ObservableCollection<NotifyObject> NotifyContent
        {
            get
            {
                if (this.notifyContent == null)
                {
                    // Not yet created.
                    // Create it.
                    this.NotifyContent = new ObservableCollection<NotifyObject>();
                }

                return this.notifyContent;
            }
            set
            {
                this.notifyContent = value;
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            Hyperlink hyperlink = sender as Hyperlink;

            if(hyperlink == null)
                return;

            NotifyObject notifyObject = hyperlink.Tag as NotifyObject;
            if(notifyObject != null)
            {
                MessageBox.Show("\"" + notifyObject.Message + "\"" + " clicked!");
            }
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            this.ForceHidden();
        }

        private void NotifyIcon_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                // Open the TaskbarNotifier
                this.Notify();
            }
        }

        private void NotifyIconOpen_Click(object sender, RoutedEventArgs e)
        {
            // Open the TaskbarNotifier
            this.Notify();
        }

        /*private void NotifyIconConfigure_Click(object sender, RoutedEventArgs e)
        {
            // Show this window
            this.Show();
            this.Activate();
        }*/

        private void NotifyIconExit_Click(object sender, RoutedEventArgs e)
        {
            // Close this window.
            this.Close();
        }
    }
}