using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.ViewInfo;

namespace WindowsApplication3 {
    public class CustomTreeList : TreeList {
        public CustomTreeList() {
        }
        protected CustomTreeList(object ignore)
            : base(ignore) { }

        protected override DevExpress.XtraTreeList.ViewInfo.TreeListViewInfo CreateViewInfo() {
            return new CustomTreeListViewInfo(this);
        }
        FilterPanelLocation filterPanelLocation;
        public FilterPanelLocation FilterPanelLocation {
            get { return filterPanelLocation; }
            set {
                if (filterPanelLocation != value) {
                    filterPanelLocation = value;
                    OnPropertyChanged();
                    LayoutChanged();
                }
            }
        }
    }
    public enum FilterPanelLocation {
        Bottom,
        Top
    }

    public class CustomTreeListViewInfo : TreeListViewInfo {

        public CustomTreeListViewInfo(TreeList treeList)
            : base(treeList) { }

        protected override Rectangle CalcClientRect(Rectangle window) {
            Rectangle rect = base.CalcClientRect(window);
            if (ShowFilterPanel && TreeList.FilterPanelLocation == FilterPanelLocation.Top) {
                Rectangle panelRect = FilterPanel.Bounds;
                panelRect.Y = rect.Y;
                FilterPanel.Bounds = panelRect;
                rect.Y += panelRect.Height;
            }
            return rect;
        }
        new CustomTreeList TreeList {
            get { return base.TreeList as CustomTreeList; }
        }
    }
}
