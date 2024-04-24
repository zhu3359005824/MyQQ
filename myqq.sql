/*
 Navicat Premium Data Transfer

 Source Server         : TestAndPractice
 Source Server Type    : MySQL
 Source Server Version : 80036 (8.0.36)
 Source Host           : localhost:3306
 Source Schema         : myqq

 Target Server Type    : MySQL
 Target Server Version : 80036 (8.0.36)
 File Encoding         : 65001

 Date: 24/04/2024 17:48:34
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for myqq_message
-- ----------------------------
DROP TABLE IF EXISTS `myqq_message`;
CREATE TABLE `myqq_message`  (
  `FromUserID` int NOT NULL,
  `ToUserID` int NOT NULL,
  `Message` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `MessageState` int(1) UNSIGNED ZEROFILL NOT NULL,
  `MessageTime` datetime NULL DEFAULT NULL
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for myqq_user
-- ----------------------------
DROP TABLE IF EXISTS `myqq_user`;
CREATE TABLE `myqq_user`  (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Password` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Remember` varchar(1) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT 'n',
  `Name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_as_ci NOT NULL,
  `Sex` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_as_ci NOT NULL,
  `Age` int NOT NULL,
  `Job` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_as_ci NOT NULL,
  `HeadID` int(1) UNSIGNED ZEROFILL NOT NULL,
  PRIMARY KEY (`ID`) USING BTREE,
  INDEX `HeadID`(`HeadID` ASC) USING BTREE,
  INDEX `Name`(`Name` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 57920 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_as_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for myqq_user_friend
-- ----------------------------
DROP TABLE IF EXISTS `myqq_user_friend`;
CREATE TABLE `myqq_user_friend`  (
  `ID` int NOT NULL,
  `FriendID` int NOT NULL,
  `FriendHeadID` int(1) UNSIGNED ZEROFILL NOT NULL,
  `FriendFlag` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT 'n',
  INDEX `好友信息`(`FriendID` ASC) USING BTREE,
  INDEX `好友头像`(`FriendHeadID` ASC) USING BTREE,
  CONSTRAINT `好友信息` FOREIGN KEY (`FriendID`) REFERENCES `myqq_user` (`ID`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `好友头像` FOREIGN KEY (`FriendHeadID`) REFERENCES `myqq_user` (`HeadID`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

SET FOREIGN_KEY_CHECKS = 1;
