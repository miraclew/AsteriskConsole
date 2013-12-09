using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using VisualAsterisk.Asterisk.Config.Configuration;
using System.ComponentModel;

namespace VisualAsterisk.Test.Asterisk.Config
{
    [TestFixture]
    public class UserExtensionTest
    {
        public void TestUserExtesionCtor()
        {
            UserExtension user = new UserExtension();
            Assert.IsNull(user.Extension);
            user.Extension = "test";
            UserExtension user2 = new UserExtension(user);
            Assert.AreEqual("test", user2.Extension);
        }

        [Test]
        public void TestUserExtensionEdit()
        {
            UserExtension user = new UserExtension();
            Assert.IsEmpty(user.Changes);
            user.Extension = "test";
            Assert.IsEmpty(user.Changes); // before BeginEdit, any property change will not add to changes
            user.BeginEdit();
            user.Extension = "test1";
            Assert.AreEqual(1, user.Changes.Count);
            user.Changes.ContainsValue(new ConfigurationChange(null, null, null, "category", "test1"));
            user.EndEdit(); // when end called, changes be locked util BeginEdit called again 
            user.Email = "test2";
            Assert.AreEqual(1, user.Changes.Count);
        }

        [Test]
        public void TestDuplicateChanges()
        {
            UserExtension user = new UserExtension();
            user.BeginEdit(); 
            user.Extension = "test1";
            user.Extension = "test2";
            Assert.AreEqual(1, user.Changes.Count);
            user.CidNumber = "test3";
            Assert.AreEqual(2, user.Changes.Count);
            user.CidNumber = "testr";
            Assert.AreEqual(2, user.Changes.Count);
        }

        [Test]
        public void TestCancelEdit()
        {
            UserExtension user = new UserExtension();
            user.Extension = "test1";
            user.Email = "test2";

            user.BeginEdit();
            user.Email = "test3";
            user.CancelEdit();
            Assert.AreEqual(0, user.Changes.Count);
            Assert.AreEqual("test2", user.Email);
        }

        [Test]
        public void TestPropertyChangeNotify()
        {
            UserExtension user = new UserExtension();
            user.PropertyChanged += new PropertyChangedEventHandler(user_PropertyChanged);
            user.Disallow = "all";
            Assert.AreSame(user, lastPropertyChangedObject);
            Assert.AreEqual("Disallow", lastChangedProperty);
        }

        void user_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            lastPropertyChangedObject = sender;
            lastChangedProperty = e.PropertyName;
        }

        private object lastPropertyChangedObject;
        private string lastChangedProperty;
    }
}
