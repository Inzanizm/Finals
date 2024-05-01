using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals
{
    public static class MyMessageBox
    {
        public static System.Windows.Forms.DialogResult ShowMessage(string message, string caption, System.Windows.Forms.MessageBoxButtons button, System.Windows.Forms.MessageBoxIcon icon)
        {
            System.Windows.Forms.DialogResult dlgResult = System.Windows.Forms.DialogResult.None;
            switch (button)
            {
                case System.Windows.Forms.MessageBoxButtons.OK:
                    using (MessageBoxOk msgOK = new MessageBoxOk())
                    {
                        //Change text, caption, icon
                        msgOK.Title = caption;
                        msgOK.Message = message;
                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information:
                                msgOK.MessageIcon = Finals.Properties.Resources.about_11660131;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Error:
                                msgOK.MessageIcon = Finals.Properties.Resources.error_icon_41;
                                break;
                        }
                        dlgResult = msgOK.ShowDialog();
                    }
                    break;
                case System.Windows.Forms.MessageBoxButtons.RetryCancel:
                    using (MessageBoxRetryCancel msgRetryCancel = new MessageBoxRetryCancel())
                    {
                        msgRetryCancel.Title = caption;
                        msgRetryCancel.Message = message;
                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Warning:
                                msgRetryCancel.MessageIcon = Finals.Properties.Resources.error_icon_4;
                                break;
                        }
                        dlgResult = msgRetryCancel.ShowDialog();
                    }
                    break;
                case System.Windows.Forms.MessageBoxButtons.YesNo:
                    using (MessageBoxYesNo msgYesNo = new MessageBoxYesNo())
                    {
                        msgYesNo.Title = caption;
                        msgYesNo.Message = message;
                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Warning:
                                msgYesNo.MessageIcon = Finals.Properties.Resources.warning_595067;
                                break;
                        }
                        dlgResult = msgYesNo.ShowDialog();
                    }
                    break;
            }
            return dlgResult;
        }
    }
}
