/*
 Navicat Premium Data Transfer

 Source Server         : 本地mysql
 Source Server Type    : MySQL
 Source Server Version : 80021
 Source Host           : 192.168.25.182:3302
 Source Schema         : supermarket

 Target Server Type    : MySQL
 Target Server Version : 80021
 File Encoding         : 65001

 Date: 18/09/2020 15:25:58
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for bill
-- ----------------------------
DROP TABLE IF EXISTS `bill`;
CREATE TABLE `bill`  (
  `bill_id` int(0) NOT NULL COMMENT '使用当前时间作为账单标记',
  `total` decimal(10, 2) NULL DEFAULT NULL COMMENT '账单总金额',
  `
actually_received` decimal(10, 2) NULL DEFAULT NULL COMMENT '实际收到',
  `state` int(0) NULL DEFAULT NULL COMMENT '1已经结账 2从未结账 3部分结账',
  `create_time` datetime(0) NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(0) COMMENT '开始时间',
  `end_time` datetime(0) NULL DEFAULT NULL COMMENT '结束时间',
  PRIMARY KEY (`bill_id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for bill_commodity
-- ----------------------------
DROP TABLE IF EXISTS `bill_commodity`;
CREATE TABLE `bill_commodity`  (
  `bill_id` int(0) NOT NULL COMMENT '单据id',
  `commodity_id` int(0) NULL DEFAULT NULL COMMENT '商品id',
  `commodity_name` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '商品名称',
  `number` int(0) NULL DEFAULT NULL COMMENT '销售数量',
  `price` decimal(10, 2) NULL DEFAULT NULL COMMENT '售价',
  `total` decimal(10, 2) NULL DEFAULT NULL COMMENT '合计',
  PRIMARY KEY (`bill_id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for bill_detail
-- ----------------------------
DROP TABLE IF EXISTS `bill_detail`;
CREATE TABLE `bill_detail`  (
  `bill_id` int(0) NOT NULL COMMENT '单据编号',
  `total` decimal(10, 2) NULL DEFAULT NULL COMMENT '支付的金额',
  `pay_type` int(0) NULL DEFAULT NULL COMMENT '支付方式',
  `create_time` datetime(0) NULL DEFAULT NULL COMMENT '创建时间',
  PRIMARY KEY (`bill_id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for commodity
-- ----------------------------
DROP TABLE IF EXISTS `commodity`;
CREATE TABLE `commodity`  (
  `id` int(10) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT,
  `name` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '名称',
  `in_price` decimal(10, 2) NULL DEFAULT NULL COMMENT '进价',
  `out_price` decimal(10, 2) NULL DEFAULT NULL COMMENT '售价',
  `stock` int(0) NULL DEFAULT NULL COMMENT '库存',
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for commodity_type
-- ----------------------------
DROP TABLE IF EXISTS `commodity_type`;
CREATE TABLE `commodity_type`  (
  `id` int(0) NOT NULL,
  `type` varchar(16) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '商品类型',
  `state` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for pay
-- ----------------------------
DROP TABLE IF EXISTS `pay`;
CREATE TABLE `pay`  (
  `id` int(10) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT,
  `pay_type` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '付款类型',
  `state` int(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of pay
-- ----------------------------
INSERT INTO `pay` VALUES (0000000001, '支付宝', 1);
INSERT INTO `pay` VALUES (0000000002, '微信', 1);
INSERT INTO `pay` VALUES (0000000003, '现金', 1);

-- ----------------------------
-- Table structure for user
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user`  (
  `id` int(10) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT,
  `user_name` varchar(16) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '用户名',
  `pwd` varchar(16) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '密码',
  `role` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '角色',
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

SET FOREIGN_KEY_CHECKS = 1;
