using System.Collections;
using System.Collections.Generic;
using Lofelt.NiceVibrations;
using UnityEngine;

namespace FallingBalls.Test
{
    public class HapticTest : MonoBehaviour
    {
        public void Success()
        {
            HapticPatterns.PlayPreset(HapticPatterns.PresetType.Success);
        }
        
        public void LightImpact()
        {
            HapticPatterns.PlayPreset(HapticPatterns.PresetType.LightImpact);
        }
        
        public void Failure()
        {
            HapticPatterns.PlayPreset(HapticPatterns.PresetType.Failure);
        }
        
        public void Selection()
        {
            HapticPatterns.PlayPreset(HapticPatterns.PresetType.Selection);
        }
        
        public void Warning()
        {
            HapticPatterns.PlayPreset(HapticPatterns.PresetType.Warning);
        }
        
        public void HeavyImpact()
        {
            HapticPatterns.PlayPreset(HapticPatterns.PresetType.HeavyImpact);
        }
        
        public void MediumImpact()
        {
            HapticPatterns.PlayPreset(HapticPatterns.PresetType.MediumImpact);
        }
        
        public void RigidImpact()
        {
            HapticPatterns.PlayPreset(HapticPatterns.PresetType.RigidImpact);
        }
        
        public void SoftImpact()
        {
            HapticPatterns.PlayPreset(HapticPatterns.PresetType.SoftImpact);
        }
    }

}