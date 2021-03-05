using System.Drawing;
using System.Windows.Forms;

namespace RED7Studios.FreePOS.PluginInterface
{
    public interface PluginImplementer
    {
        string PluginName();
        string PluginVersion();
        string PluginAuthor();
        string PluginSignature();
        string PluginDescription();
        Icon PluginIcon();

        void AdminButtonAdder(Button btn);
        void EmployeeButtonAdder(Button btn);
        void DashboardMenuAdder(ToolStripMenuItem tsi);
        void CreateOrderMenuAdder(ToolStripMenuItem tsi);
        void OrderListMenuAdder(ToolStripMenuItem tsi);
    }
}