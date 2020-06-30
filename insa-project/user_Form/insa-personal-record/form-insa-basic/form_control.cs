using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insa_project
{
    class form_control
    {
        List<Control> get_control_list = new List<Control>();

        public Boolean control_nullcheck()
        {
            foreach (Control b in get_control_list)
            {
                if (b.Enabled == true)
                {
                    if (string.IsNullOrEmpty(b.Text))
                    {
                        MessageBox.Show("빈값을 넣을 수 없습니다.");
                        b.Focus();
                        if (b.GetType() == typeof(ComboBox))
                        {
                            (b as ComboBox).Select();
                            (b as ComboBox).DroppedDown = true;
                        }
                        Console.WriteLine(b.Name + ":" + b.Text);
                        return true;
                        
                    }
                    
                }
            }
            return false;
        }

        public void control_reset()
        {
            foreach (Control b in get_control_list)
            {
                Console.WriteLine("reset:" + b.Name);
                b.ResetText();
                if(b.GetType() == typeof(ComboBox)) (b as ComboBox).SelectedItem = null;
                if (b.GetType() == typeof(RichTextBox)) (b as RichTextBox).Clear();
            }
        }

        public void control_enabled(Boolean check)
        {
            foreach (Control b in get_control_list)
            {
                b.Enabled = check;

                if(b.GetType() == typeof(DateTimePicker))
                {
                    if(b.Enabled == false)
                    {
                        (b as DateTimePicker).CustomFormat = " ";
                        (b as DateTimePicker).Format = DateTimePickerFormat.Custom;
                    }
                    else
                    {
                        (b as DateTimePicker).CustomFormat = "yyyy-MM-dd";
                        (b as DateTimePicker).Format = DateTimePickerFormat.Custom;
                    }
                }
            }
        }

        public void get_control(Form form, Boolean allcheck)
        {
            get_control_list.Clear();

            foreach (Control a in form.Controls)
            {
                foreach (Control b in a.Controls)
                {
                    if (allcheck)
                    {
                        get_control_list.Add(b);
                    }
                    else
                    {
                        if (b.GetType() == typeof(TextBox) || b.GetType() == typeof(RichTextBox) || b.GetType() == typeof(ComboBox) || b.GetType() == typeof(MaskedTextBox))
                        {
                            get_control_list.Add(b);
                        }
                    }
                }
            }
        }
    }
}
