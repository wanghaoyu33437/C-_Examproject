/*
Navicat MySQL Data Transfer

Source Server         : why
Source Server Version : 50562
Source Host           : localhost:3306
Source Database       : market

Target Server Type    : MYSQL
Target Server Version : 50562
File Encoding         : 65001

Date: 2019-12-10 17:28:38
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for position
-- ----------------------------
DROP TABLE IF EXISTS `position`;
CREATE TABLE `position` (
  `pos_id` varchar(11) NOT NULL,
  `pos_name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`pos_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of position
-- ----------------------------
INSERT INTO `position` VALUES ('1', '经理');
INSERT INTO `position` VALUES ('2', '员工');

-- ----------------------------
-- Table structure for staff
-- ----------------------------
DROP TABLE IF EXISTS `staff`;
CREATE TABLE `staff` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `sta_name` varchar(30) DEFAULT NULL,
  `sta_pwd` varchar(30) DEFAULT NULL,
  `sta_num` varchar(255) DEFAULT NULL,
  `sta_sex` varchar(255) DEFAULT NULL,
  `sta_age` varchar(255) DEFAULT NULL,
  `pos_id` varchar(20) DEFAULT NULL,
  `sta_startime` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `sta_pos` (`pos_id`),
  CONSTRAINT `sta_pos` FOREIGN KEY (`pos_id`) REFERENCES `position` (`pos_id`) ON DELETE SET NULL ON UPDATE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of staff
-- ----------------------------
INSERT INTO `staff` VALUES ('1', 'why', '1234', '1778990', '男', '18', '1', '2017年9月');
INSERT INTO `staff` VALUES ('4', 'aa', '123', '1122', '男', '19', '1', '2017年9月');

-- ----------------------------
-- Table structure for system
-- ----------------------------
DROP TABLE IF EXISTS `system`;
CREATE TABLE `system` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `sys_name` varchar(30) DEFAULT NULL,
  `sys_pwd` varchar(30) DEFAULT NULL,
  `sys_num` varchar(255) DEFAULT NULL,
  `sta_sex` varchar(255) DEFAULT NULL,
  `sta_age` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of system
-- ----------------------------
INSERT INTO `system` VALUES ('1', 'why', '123', '1778990', '男', '18');
INSERT INTO `system` VALUES ('2', 'why', '123', 'aaa', '男', '18');

-- ----------------------------
-- Table structure for vip
-- ----------------------------
DROP TABLE IF EXISTS `vip`;
CREATE TABLE `vip` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `vip_num` varchar(255) DEFAULT NULL,
  `vip_name` varchar(255) DEFAULT NULL,
  `vip_sex` varchar(255) DEFAULT NULL,
  `vip_age` varchar(255) DEFAULT NULL,
  `vip_money` varchar(255) DEFAULT NULL,
  `vip_pwd` varchar(255) DEFAULT NULL,
  `vip_phone` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of vip
-- ----------------------------
INSERT INTO `vip` VALUES ('1', '578111', '罗贤哲', '男', '13', '700', '123', '17370837789');
INSERT INTO `vip` VALUES ('3', '0925923950', '弟弟', '男', '19', '1000', '123', '11223344556');
