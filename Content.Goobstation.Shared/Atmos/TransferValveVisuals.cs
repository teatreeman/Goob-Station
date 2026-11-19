// SPDX-License-Identifier: AGPL-3.0-or-later

using Robust.Shared.Serialization;

namespace Content.Goobstation.Shared.Atmos;

[Serializable, NetSerializable]
public enum TransferValveVisuals : byte
{
    TankOne,
    TankTwo,
    Device,
    Empty,
}
