import os
import sys

sys.path.append(os.path.abspath(os.path.join(os.path.dirname(__file__), "../ScriptUtils")))
from Core.Blender.BlenderExport import run_blender_export

run_blender_export(
    "ArtSources/Flag.blend", 
    "Assets/Fbx",
    "true", 
    ["Flag","Flag.001","Flag.002","Stand"])