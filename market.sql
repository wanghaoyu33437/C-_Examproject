/*
Navicat MySQL Data Transfer

Source Server         : why
Source Server Version : 50562
Source Host           : localhost:3306
Source Database       : market

Target Server Type    : MYSQL
Target Server Version : 50562
File Encoding         : 65001

Date: 2019-12-09 18:38:19
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
INSERT INTO `staff` VALUES ('1', 'why', '123', '1778990', '男', '18', '1', '2017年9月');
INSERT INTO `staff` VALUES ('2', 'why', '123', 'aaa', '男', '18', '1', '2017年9月');
INSERT INTO `staff` VALUES ('3', 'aaa', '123', 'aaa', '男', '18', '1', '2017');
INSERT INTO `staff` VALUES ('4', 'aa', null, null, null, null, null, null);
INSERT INTO `staff` VALUES ('5', 'aaa', '123', 'aaa', '男', '18', '1', '2017');
INSERT INTO `staff` VALUES ('6', 'aa', 'sdas', 'aaa', 'asd', '12', '1', '123');

-- ----------------------------
-- Table structure for vip
-- ----------------------------
DROP TABLE IF EXISTS `vip`;
CREATE TABLE `vip` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `sys_name` varchar(255) DEFAULT NULL,
  `sys_num` varchar(255) DEFAULT NULL,
  `sys_pwd` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of vip
-- ----------------------------
INSERT INTO `vip` VALUES ('1', '罗贤哲', '578111', '123');
