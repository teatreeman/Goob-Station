// SPDX-License-Identifier: AGPL-3.0-or-later

using Robust.Shared.Serialization;

namespace Content.Goobstation.Shared.Atmos;

/// <summary>
/// Appearance data for the transfer valve. The tank keys hold the sprite state of the tank on that port, or an empty
/// string when the port is free.
/// </summary>
[Serializable, NetSerializable]
public enum TransferValveVisuals : byte
{
    TankOne,
    TankTwo,
    Device,
    Wired,
}

/// <summary>
/// Sprite layers of the transfer valve.
/// </summary>
public enum TransferValveVisualLayers : byte
{
    Base,
    TankOne,
    TankTwo,
    Device,
    Cables,
}
