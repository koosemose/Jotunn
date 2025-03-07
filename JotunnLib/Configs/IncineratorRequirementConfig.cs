﻿using Jotunn.Entities;

namespace Jotunn.Configs
{
    /// <summary>
    ///     Wrapper for the <see cref="Incinerator.Requirement"/>
    /// </summary>
    public class IncineratorRequirementConfig
    {
        /// <summary>
        ///     Name of the item prefab of this incinerator requirement
        /// </summary>
        public string Item { get; set; }

        /// <summary>
        ///     Amount that is needed to fulfill the requirement. Defaults to 1.
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        ///     Creates a Valheim Piece.Requirement from this config. 
        /// </summary>
        /// <returns></returns>
        public Incinerator.Requirement GetRequirement()
        {
            return new Incinerator.Requirement
            {
                m_resItem = Mock<ItemDrop>.Create(Item),
                m_amount = Amount
            };
        }
    }
}
