// SPDX-License-Identifier: AGPL-3.0-or-later

using Robust.Shared.Serialization;

namespace Content.Goobstation.Shared.Atmos;

[Serializable, NetSerializable]
public enum TransferValveVisuals : byte
{
    /// <summary>
    /// Sprite state of the first tank, or empty when there isn't one.
    /// </summary>
    TankOne,
    TankTwo,
    Device,
    Wired,
}

public enum TransferValveVisualLayers : byte
{
    Base,
    TankOne,
    TankTwo,
    Device,
    Cables,
}
