using System.Collections.ObjectModel;

namespace Ameko.Models;

public class EventGridItems : ObservableCollection<EventGridItem>
{
    public EventGridItems()
    {
        this.Add(new EventGridItem(1));
    }
}