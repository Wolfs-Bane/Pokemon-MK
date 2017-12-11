﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronRuby;
using Microsoft.Scripting.Hosting;
using static PokemonEngine.Util;
using System.IO;

namespace PokemonEngine
{
    public class MapInterpreter
    {
        /// <summary>
        /// Loads a map data file based on ID and parses it to C# object.
        /// </summary>
        public static Map Parse(int id)
        {
            Dictionary<string, dynamic> Data = new Dictionary<string, dynamic>();
            List<List<dynamic>> Layers = new List<List<dynamic>>();

            ScriptEngine engine = Ruby.CreateEngine();
            dynamic ret = engine.Execute($@"
f = File.open(""Maps/{Digits(id)}.mkd"", ""rb"")
Data = Marshal.load(f)
f.close
return [Data[0],Data[1..-1]]");

            // Parses the Layer data to C# objects (in Lists instead of Arrays)
            dynamic[] _layers = ret[1].ToArray();
            for (int i = 0; i < _layers.Length; i++)
            {
                List<dynamic> Layer = new List<dynamic>();
                dynamic[] _layer = ((IronRuby.Builtins.RubyArray) _layers[i]).ToArray();
                for (int j = 0; j < _layer.Length; j++)
                {
                    if (_layer[j] is IronRuby.Builtins.RubyArray)
                    {
                        dynamic[] _tile = ((IronRuby.Builtins.RubyArray) _layer[j]).ToArray();
                        List<dynamic> Tile = new List<dynamic>();
                        for (int k = 0; k < _tile.Length; k++)
                        {
                            int TileData = Convert.ToInt32(_tile[k].ToString());
                            Tile.Add(TileData);
                        }
                        Layer.Add(Tile);
                    }
                    else
                    {
                        Layer.Add(Convert.ToInt32(_layer[j].ToString()));
                    }
                }
                Layers.Add(Layer);
            }

            int Width = Convert.ToInt32(ret[0][0].ToString());
            int Height = Convert.ToInt32(ret[0][1].ToString());
            string Tileset = ret[0][2].ToString();
            string Name = ret[0][3].ToString();

            return new Map(id, Layers, Width, Height, Tileset, Name);
        }
    }

    public class Map
    {
        /// <summary>
        /// Isn't stored in the map data file itself, but uses the filename to determine its ID.
        /// </summary>
        public int ID { get; set; }
        public List<List<dynamic>> Layers { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Tileset { get; set; }
        public string Name { get; set; }

        public Map(int ID, List<List<dynamic>> Layers, int Width, int Height, string Tileset, string Name)
        {
            this.ID = ID;
            this.Layers = Layers;
            this.Width = Width;
            this.Height = Height;
            this.Tileset = Tileset;
            this.Name = Name;
        }

        public bool Update(int OldWidth, int OldHeight)
        {
            List<List<dynamic>> NewLayers = new List<List<dynamic>>();
            for (int l = 0; l < Layers.Count; l++)
            {
                List<dynamic> NewLayer = new List<dynamic>();
                for (int i = 0; i < Layers[l].Count; i++)
                {
                    NewLayer.Add(Layers[l][i]);
                    if (i % OldWidth == OldWidth - 1)
                    {
                        for (int k = 0; k < Width - OldWidth; k++)
                        {
                            NewLayer.Add(0);
                        }
                    }
                }
                for (int i = 0; i < Height - OldHeight; i++)
                {
                    for (int k = 0; k < Width; k++)
                    {
                        NewLayer.Add(0);
                    }
                }
                NewLayers.Add(NewLayer);
            }
            bool ret = (Layers[0].Count != NewLayers.Count);
            Layers = NewLayers;
            return ret;
        }
    }
}
