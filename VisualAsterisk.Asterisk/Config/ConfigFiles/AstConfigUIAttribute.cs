using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config
{
    class AstConfigUIAttribute
    {
    }

    [AttributeUsage(AttributeTargets.All)]
    public class UILabelAttribute : System.Attribute
    {
        public UILabelAttribute(string label)
        {
            this.label = label;
        }
        string label;

        public string Label
        {
            get { return label; }
            set { label = value; }
        }
    }

    public enum UIItemType
    {
        LIST, DETAIL
    }

    [AttributeUsage(AttributeTargets.All)]
    public class UIItemAttribute : System.Attribute
    {
        public UIItemAttribute(string label, UIItemType itemType, int index, string group)
        {
            this.label = label;
            this.itemType = itemType;
            this.index = index;
            this.group = group;
        }
        string label;

        public string Label
        {
            get { return label; }
            set { label = value; }
        }
        UIItemType itemType;

        public UIItemType ItemType
        {
            get { return itemType; }
            set { itemType = value; }
        }
        int index;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        string group;

        public string Group
        {
            get { return group; }
            set { group = value; }
        }

    }

    [AttributeUsage(AttributeTargets.All)]
    public class UIDisplayMemeberAttribute : System.Attribute
    {
        public UIDisplayMemeberAttribute(string member)
        {
            this.member = member;
        }
        string member;

        public string Member
        {
            get { return member; }
            set { member = value; }
        }
        
    }
}
