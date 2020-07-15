//
//  Heartbeat.cs
//
//  Author:
//       Jarl Gullberg <jarl.gullberg@gmail.com>
//
//  Copyright (c) 2017 Jarl Gullberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

namespace Remora.Discord.Gateway.API.Commands
{
    /// <summary>
    /// Represents a heartbeat command to or from Discord.
    /// </summary>
    public class Heartbeat
    {
        /// <summary>
        /// Gets the last sequence number received by the client.
        /// </summary>
        public long? LastSequenceNumber { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Heartbeat"/> class.
        /// </summary>
        /// <param name="lastSequenceNumber">The last sequence number received by the client.</param>
        public Heartbeat(long? lastSequenceNumber)
        {
            this.LastSequenceNumber = lastSequenceNumber;
        }
    }
}