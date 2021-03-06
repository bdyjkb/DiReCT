﻿/**
 * Copyright (c) 2016 DRBoaST
 *
 * Project Name:
 *
 * 		DiReCT(Disaster Record Capture Tool)
 *
 * Version:
 *
 * 		1.0
 *
 * File Name:
 *
 * 		DebrisFlowRecord.cs
 *
 * Abstract:
 *
 * 		DebrisFlowRecord is a subclass inherited ObservationRecord.     
 *
 * Authors:
 *
 * 		Johnson Su, johnsonsu@iis.sinica.edu.tw
 *      Jeff Chen, jeff@iis.sinica.edu.tw
 *
 * License:
 *
 * 		GPL 3.0 This file is subject to the terms and conditions defined
 * 		in file 'COPYING.txt', which is part of this source code package.
 *
 */
using System;
using System.Collections.Generic;
using System.Device.Location;

namespace DiReCT.ObjectModel.Observations
{
    class DebrisFlowRecord : ObservationRecord
    {

        /// <summary>
        /// 岩性組合
        /// Four rock Lithology and combination.
        /// </summary>
        public struct RockLithology
        {

            /// <summary>
            /// 沉積岩
            /// Types of Sedimetary Rock.
            /// </summary>
            enum SedimetaryRock
            {

                Conglomerate,
                Sandstone,
                Siltstone,
                Shale,
                Mudstone,
                Limestone
            }

            /// <summary>
            /// 變質岩
            /// Types of Metamorphic Rock.
            /// </summary>
            enum MetamorphicRock
            {
                Quartzite,
                Marble,
                Amphibolite,
                Gneiss,
                GraniticGneiss,
                Schist,
                Phyllite,
                Slate,
                Hornfels,
                Greywacke,
                Argillite
            }

            /// <summary>
            /// 火成岩
            /// Types of Igneous Rock.
            /// </summary>
            enum IgneousRock
            {
                Peridotite,
                Gabbro,
                Diorite,
                Granite,
                Granodiorite,
                Basalt,
                Andesite,
                Rhyolite,
                VolcanicGlass,
                QuartzVein,
                Agglomerate,
                Ignimbrite,
                Tuff,
                Lahar
            }

            /// <summary>
            /// 堆積物
            /// Types of Sedoment Rock.
            /// </summary>
            enum SedimentRock
            {
                GarvelTerrace,
                Sandstone,
                ClayLayer,
                Peat,
                Agglomerate,
                Lapilli,
                VolcanicAsh
            }
        }

        /// <summary>
        /// 集水區相關
        /// Catchment relative
        /// </summary>
        public struct Catchment
        {
            /// <summary>
            /// 集水區面積
            /// Area of the catchment.
            /// </summary>
            public int CatchmentArea { get; set; }

            /// <summary>
            /// 集水區內崩塌率
            /// The Landslide rate in catchment.
            /// </summary>
            public enum CatchmentLandslideRate
            {
                UnderOnePercent,
                OneToFivePercent,
                AboveFivePercent
            }

            /// <summary>
            /// 集水區內崩塌規模
            /// Landslide scale in catchment.
            /// </summary>
            public enum CatchmentLandslideScale
            {
                NoObviousLandslide,
                SmallScaleLandslide,
                ObviousBigRegionLandslide
            }

        }

        /// <summary>
        /// 坡度相關
        /// Slope relative.
        /// </summary>
        public struct Slope
        {
            /// <summary>
            /// 發生區上游坡度
            /// The Slope of upstream.
            /// </summary>
            public enum OccurRegionUpstreamSlope
            {
                AboveFiftyDegrees,
                ThirtyToFiftyDegrees,
                UnderThirtyDegrees
            }
        }



        /// <summary>
        /// 溪流災害類型-其他描述
        /// Other discriptions of torrent disaster.
        /// </summary>
        public string TorrentDisasterTypeDiscription { get; set; }


        /// <summary>
        /// 溪流災害類型
        /// Type of the torrent disaster.
        /// </summary>
        public enum TorrentDisasterType
        {
            DebrisFlow,
            DebrisSlump,
            GullyErosion,
            ShallowSlide,
            Others
        }

        /// <summary>
        /// 堆積區土石粒徑情形
        /// The diameter of rock in aggradation.
        /// </summary>
        public enum AggradationRockDiameter
        {
            AboveThirtyCM,
            EightToThirtyCM,
            UnderEightCM,
            NoObviousRock
        }

        /// <summary>
        /// 集水區內主要植生生長種類
        /// The main vegetation category in catchment.
        /// </summary>
        public enum MainVegetationCategory
        {
            Naked,
            Meadow,
            ArtificialForest,
            NaturalForest
        }

        /// <summary>
        /// 集水區內主要植生生長狀況
        /// The main vegetations grow situation in catchment. 
        /// </summary>
        public enum MainVegetationGrowthSituation
        {
            BareLend,
            UnderTenPercent,
            TenToThirtyPercent,
            ThirtyToEightyPercent,
            AboveEightyPercent
        }

        /// <summary>
        /// 現場初估發生潛勢因子
        /// Estimate the potential factor. 
        /// </summary>
        public enum LocationPotentialFactor
        {
            High,
            Medium,
            Low
        }

        /// <summary>
        /// 現場初估風險潛勢等級
        /// Level of potential risk.
        /// </summary>
        public enum RiskPotentialLevel
        {
            High,
            Medium,
            Low
        }
    }
}

