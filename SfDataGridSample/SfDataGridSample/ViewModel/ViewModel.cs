using Syncfusion.Maui.DataGrid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridSample
{
public class ViewModel : INotifyPropertyChanged
{
    private Command clearSelection;
    public Command ClearSelection
    {
        get
        {
            return clearSelection;
        }
    }       

    private void ClearSelectionCommand(object obj)
    {
        var dataGrid = obj as SfDataGrid;
        dataGrid.SelectionMode = DataGridSelectionMode.None;
    }
        
    OrderInfoRepository order;
    public ViewModel()
    {
        order = new OrderInfoRepository();
        clearSelection = new Command(ClearSelectionCommand);
        SetRowstoGenerate(50);
    }

    private ObservableCollection<OrderInfo> ordersInfo;
    public ObservableCollection<OrderInfo> OrdersInfo
    {
        get { return ordersInfo; }
        set { this.ordersInfo = value; }
    }

    public void SetRowstoGenerate(int count)
    {
        ordersInfo = order.GetOrderDetails(count);
    }

    public event PropertyChangedEventHandler PropertyChanged;
    public void RaisePropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }
}
}
