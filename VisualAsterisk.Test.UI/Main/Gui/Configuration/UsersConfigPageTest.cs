using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using VisualAsterisk.Asterisk.Config.Configuration;
using System.ComponentModel;
using VisualAsterisk.Main.Gui.Configuration;
using System.Windows.Forms;

namespace VisualAsterisk.Test.Main.Gui.Configuration
{
    [TestFixture]
    public class UsersConfigPageTest
    {
        private BindingList<UserExtension> users;
        private UserExtension defaultUser;
        [SetUp]
        public void Setup()
        {
            defaultUser = new UserExtension();
            defaultUser.Extension = "6000";
            defaultUser.FullName = "Default";
            users = new BindingList<UserExtension>();
            for (int i = 0; i < 10; i++)
            {
                UserExtension exten = new UserExtension();
                exten.Extension = "600" + i.ToString();
                exten.FullName = "Test" + i.ToString();
                users.Add(exten);
            }
            users.AddingNew += new AddingNewEventHandler(users_AddingNew);
            users.ListChanged += new ListChangedEventHandler(users_ListChanged);
        }

        void users_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {

            }
        }

        void users_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new UserExtension();
        }

        [Test]
        public void Test1()
        {
            UsersConfigPage pannel = new UsersConfigPage();
            pannel.Users = users;
            pannel.DefaultUser = defaultUser;
            Application.Run(pannel);
        }

        public void Run()
        {
            Setup();
            Test1();
        }

    }
}
