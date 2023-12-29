using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project.Helpers
{
    public interface ProfileBarContainer
    {
        void PerformNotificationAction(NotificationType type);

        void GoToChangePassword();
        void SignOut();
    }
}
