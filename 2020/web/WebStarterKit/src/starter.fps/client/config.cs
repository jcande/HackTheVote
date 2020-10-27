// Torque Input Map File
moveMap.delete();
new ActionMap(moveMap);
moveMap.bindCmd(keyboard, "escape", "", "escapeFromGame();");
moveMap.bind(keyboard, "f2", showPlayerList);
moveMap.bind(keyboard, "a", moveleft);
moveMap.bind(keyboard, "w", moveForward);
moveMap.bind(keyboard, "space", jump);
moveMap.bind(keyboard, "r", movebackward);
moveMap.bind(keyboard, "e", toggleZoom);
moveMap.bind(keyboard, "z", toggleFreeLook);
moveMap.bind(keyboard, "tab", toggleFirstPerson);
moveMap.bind(keyboard, "cmd c", toggleCamera);
moveMap.bindCmd(keyboard, "ctrl w", "commandToServer(\'playCel\',\"wave\");", "");
moveMap.bindCmd(keyboard, "ctrl s", "commandToServer(\'playCel\',\"salute\");", "");
moveMap.bindCmd(keyboard, "ctrl k", "commandToServer(\'suicide\');", "");
moveMap.bindCmd(keyboard, "h", "commandToServer(\'use\',\"HealthKit\");", "");
moveMap.bindCmd(keyboard, "1", "commandToServer(\'use\',\"Crossbow\");", "");
moveMap.bind(keyboard, "u", toggleMessageHud);
moveMap.bind(keyboard, "pageup", pageMessageHudUp);
moveMap.bind(keyboard, "pagedown", pageMessageHudDown);
moveMap.bind(keyboard, "p", resizeMessageHud);
moveMap.bind(keyboard, "f3", startRecordingDemo);
moveMap.bind(keyboard, "f4", stopRecordingDemo);
moveMap.bind(keyboard, "f8", dropCameraAtPlayer);
moveMap.bind(keyboard, "f7", dropPlayerAtCamera);
moveMap.bind(keyboard, "ctrl o", bringUpOptions);
moveMap.bind(keyboard, "s", moveright);
moveMap.bind(mouse0, "xaxis", yaw);
moveMap.bind(mouse0, "yaxis", pitch);
moveMap.bind(mouse0, "button0", mouseFire);