using System.Windows;

namespace VirtualPanelTest
{
    public interface IPageInfo
    {
        int PageCount { get; }

        int CurrentPage { get; set; }

        Rect CurrentPageRect { get; }

        void BeginUpdate();

        void EndUpdate();
    }
}