﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using TCS_business.CONTROLER;

namespace TCS_business.MODEL
{
    /// <summary>
    ///  Class representing the board, holds information 
    ///  about the board and players positions.
    ///  
    /// <author>Lukasz Kostrzewa</author>
    /// </summary>
    [Serializable]
    public class Board : ISerializable
    {
        /// <summary>
        ///  List of fields on the board
        /// </summary>
        private Field[] fields;
        public Field[] Fields { get { return fields; } }

        /// <summary>
        ///  Current positions of players on the board
        /// </summary>
        private Dictionary<Player, int> positions;     
        public Dictionary<Player, int> Positions
        {
            get { return positions; }
        }

        #region Constants
        /// <summary>
        ///  Number of fields on the board
        /// </summary>
        public const int NOFIELDS = 40;
        
        /// <summary>
        ///  Money which player gets when passes through the start
        /// </summary>
        public const int CASHFORSTART = 200;
        #endregion

        private Deck deck;
        public Deck Deck { get { return deck; } }

        public Board()
        {
            positions = new Dictionary<Player, int>();
            fields = new Field[NOFIELDS];
            deck = new Deck();
        }

        /// <summary>
        ///  Initialize the board, sets players on the start field,
        ///  initialize the list of fields.
        /// </summary>
        public void Init(GameState gameState)
        {
            foreach (Player p in gameState.PlayersList)
            {
                positions.Add(p, 0);
            }
        }

        /// <summary>
        ///  Move player <c>meshes</c> fields forward.
        ///  If player has passed through the start, he or she 
        ///  gets <c>CASHFORSTART</c> amount of money.
        /// </summary>
        /// <param name="player">player to move</param>
        /// <param name="meshes">number of meshes that player has thrown</param>
        public void MovePlayer(Player player, int meshes)
        {
            if (player.InJail) return;
            positions[player] += meshes;
            if (positions[player] >= NOFIELDS)
            {
                positions[player] %= NOFIELDS;
                player.Cash += CASHFORSTART;
            }
        }

        /// <summary>
        ///  Move player to specific field.
        /// </summary>
        /// <param name="player">player to move</param>
        /// <param name="fieldNr">destination</param>
        public void MovePlayer(int fieldNr, Player player)
        {
            if (player.InJail) return;
            positions[player] = fieldNr;
        }

        #region Serialization
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("fields", fields);
            info.AddValue("positions", positions);
        }

        /// <summary>
        ///  Deserialization constructor
        /// </summary>
        /// <param name="info"></param>
        /// <param name="ctxt"></param>
        public Board(SerializationInfo info, StreamingContext ctxt)
        {
            fields = (Field[])info.GetValue("fields", typeof(Field[]));
            positions = (Dictionary<Player, int>)info.GetValue("positions", typeof(Dictionary<Player, int>));
        }
        #endregion

        internal Field PlayerPosition(Player p)
        {
            return fields[positions[p]];
        }
    }
}
