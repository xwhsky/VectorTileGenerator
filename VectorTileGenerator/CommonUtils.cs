using OSGeo.OGR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VectorTileGenerator
{
    public static class CommonUtils
    {
        public static IList<Layer> GetDatasetLayers(OSGeo.OGR.DataSource dataset)
        {
            IList<Layer> layers = new List<Layer>();
            var layerCount = dataset.GetLayerCount();
            for (int i = 0; i < layerCount; i++)
                layers.Add(dataset.GetLayerByIndex(i));
            return layers;
        }

        public static Geometry RectExtentToGeometry(RectExtent rectExtent)
        {
            Geometry ring = new Geometry(wkbGeometryType.wkbLinearRing);
            ring.AddPoint_2D(rectExtent.LeftUp.Lon, rectExtent.LeftUp.Lat);
            ring.AddPoint_2D(rectExtent.RightUp.Lon, rectExtent.RightUp.Lat);
            ring.AddPoint_2D(rectExtent.RightDown.Lon, rectExtent.RightDown.Lat);
            ring.AddPoint_2D(rectExtent.LeftDown.Lon, rectExtent.LeftDown.Lat);
            ring.AddPoint_2D(rectExtent.LeftUp.Lon, rectExtent.LeftUp.Lat);

            Geometry geometry = new Geometry(wkbGeometryType.wkbPolygon);
            geometry.AddGeometry(ring);
            return geometry;
        }

        public static Geometry EnvelopeToGeometry(Envelope envelope)
        {
            Geometry ring = new Geometry(wkbGeometryType.wkbLinearRing);
            ring.AddPoint_2D(envelope.MinX,envelope.MaxY);
            ring.AddPoint_2D(envelope.MaxX,envelope.MaxY);
            ring.AddPoint_2D(envelope.MaxX, envelope.MinY);
            ring.AddPoint_2D(envelope.MinX, envelope.MinY);
            ring.AddPoint_2D(envelope.MinX, envelope.MaxY);

            Geometry geometry = new Geometry(wkbGeometryType.wkbPolygon);
            geometry.AddGeometry(ring);
            return geometry;
        }

        public static RectExtent EnvelopeToRectExtent(Envelope envelope)
        {
            RectExtent result = new RectExtent();
            result.LeftUp = new Coord() { Lon = envelope.MinX, Lat = envelope.MaxY };
            result.Width = envelope.MaxX - envelope.MinX;
            result.Height = envelope.MaxY - envelope.MinY;
            return result;
        }
    }
}
