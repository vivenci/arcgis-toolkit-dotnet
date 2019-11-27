﻿#if XAMARIN
using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.UI.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Esri.ArcGISRuntime.Toolkit.UI.Controls
{
    public partial class Bookmarks
    {
        private GeoView _geoView;

        /// <summary>
        /// Gets or sets the geoview that contain the layers whose symbology and description will be displayed.
        /// </summary>
        /// <seealso cref="MapView"/>
        /// <seealso cref="SceneView"/>
        private GeoView GeoViewImpl
        {
            get => _geoView;
            set
            {
                if (_geoView != value)
                {
                    var oldView = _geoView;
                    _geoView = value;
                    OnViewChanged(oldView, _geoView);
                }
            }
        }

        private IList<Bookmark> BookmarkListImpl { get; set; }

        private bool PrefersBookmarkListImpl { get; set; } = false;
    }
}
#endif