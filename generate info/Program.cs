using System.Text.Json;
using generate_info;

var random = new Random();
var avlIds = new[]
{
    28, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 43, 44, 45, 46, 47, 51, 53, 54, 55, 56, 59, 60, 61, 62, 63,
    64, 65, 66, 67, 68, 69, 71, 72, 73, 75, 76, 88, 93, 97, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108,
    109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129,
    130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150,
    151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171,
    172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192,
    193, 194, 195, 196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213,
    214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234,
    235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 257,
    258, 259, 260, 261, 262, 263, 264, 265, 266, 267, 268, 269, 270, 271, 272, 273, 274, 275, 276, 277, 278,
    279, 280, 281, 282, 283, 284, 285, 286, 287, 288, 289, 290, 291, 292, 293, 294, 295, 296, 297, 298, 299,
    300, 301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319, 320,
    321, 322, 323, 324, 325, 326, 327, 328, 329, 330, 331, 332, 333, 334, 424, 427, 428, 429, 430, 431, 432,
    433, 434, 435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 445, 446, 447, 448, 449, 450, 451, 452, 453,
    454, 455, 456, 457, 458, 459, 460, 461, 462, 463, 464, 465, 466, 467, 468, 469, 470, 471, 472, 473, 474,
    475, 476, 477, 478, 479, 480, 481, 482, 483, 484, 485, 486, 487, 488, 489, 490, 491, 492, 493, 494, 495,
    496, 497, 498, 499, 500, 501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 515, 516,
    517, 518, 519, 520, 521, 522, 523, 524, 525, 526, 527, 528, 529, 530, 531, 532, 533, 534, 535, 536, 537,
    538, 539, 540, 541, 542, 543, 544, 545, 546, 547, 548, 549, 550, 551, 552, 553, 554, 555, 556, 557, 558,
    559, 560, 561, 562, 563, 564, 565, 566, 567, 568, 569, 570, 571, 572, 573, 574, 575, 576, 577, 578, 579,
    580, 581, 582, 583, 584, 585, 586, 587, 588, 589, 590, 591, 592, 593, 594, 595, 596, 597, 598, 599, 600,
    601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621,
    622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633, 634, 635, 636, 637, 638, 639, 640, 641, 642,
    643, 644, 645, 646, 647, 648, 649, 650, 651
}; // Add all valid AvlIDs here
var writer = new StreamWriter("C:\\Users\\Radshid\\Desktop\\New folder\\asd.txt");
var infos = new List<string>();
for (var i = 0; i < 50000; i++)
{
    var pointInfo = new PointInfo
    {
        AvlID = avlIds[random.Next(avlIds.Length)],
        PointDate = DateTime.Now.AddDays(-random.Next(365)),
        InsertDate = DateTime.Now,
        PacketID = random.Next(1, int.MaxValue),
        Longitude = (decimal)random.NextDouble() * 180 - 90,
        Latitude = (decimal)random.NextDouble() * 90 - 45,
        Altitude = (short)random.Next(-100, 10000),
        Angle = (short)random.Next(0, 360),
        SatelliteCount = (byte)random.Next(0, 12),
        Speed = (short)random.Next(0, 200),
        Reset = (short)random.Next(0, 2),
        ChangeOff = random.Next(0, 2) == 1,
        HighSpeed = random.Next(0, 2) == 1,
        Memory1IsConnect = random.Next(0, 2) == 1,
        Memory2IsConnect = random.Next(0, 2) == 1,
        IsFromMemory = random.Next(0, 2) == 1,
        InternalFlashPointCount = (short)random.Next(0, 100),
        OffTimes = random.Next(0, 100),
        PauseTimes = (short)random.Next(0, 10),
        ExtraJson = "", // You can customize this if needed
        Alarm = random.Next(0, 2) == 1,
        IsOn = random.Next(0, 2) == 1,
        ConnectToBattery = random.Next(0, 2) == 1,
        Sos = random.Next(0, 2) == 1,
        SimCardCharge = random.Next(0, 100),
        Counter = random.Next(0, 1000),
        SignalQualityGSM = (byte)random.Next(0, 4),
        MaxSpeed = (short)random.Next(0, 250)
    };
    infos.Add(JsonSerializer.Serialize(pointInfo));
}
writer.WriteLine("[");
for (var i = 0; i < infos.Count; i++)
{
    writer.WriteLine(infos[i] + (i < infos.Count - 1 ? "," : ""));
}
writer.WriteLine("]");

writer.Close();
Console.WriteLine("finished");