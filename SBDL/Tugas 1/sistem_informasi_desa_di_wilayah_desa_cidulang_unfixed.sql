-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 06, 2020 at 07:39 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.2.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sistem_informasi_desa_di_wilayah_desa_cidulang`
--

-- --------------------------------------------------------

--
-- Table structure for table `buku_tamu`
--

CREATE TABLE `buku_tamu` (
  `id` int(11) NOT NULL,
  `nama` varchar(20) DEFAULT NULL,
  `email` varchar(20) DEFAULT NULL,
  `url` varchar(30) DEFAULT NULL,
  `komentar` text DEFAULT NULL,
  `tgl` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `buku_tamu`
--

INSERT INTO `buku_tamu` (`id`, `nama`, `email`, `url`, `komentar`, `tgl`) VALUES
(1, 'Samsudin', 'samsudin22@gmail.com', 'samsudin.com', 'anjay mabar, bos', '2020-03-06');

-- --------------------------------------------------------

--
-- Table structure for table `data_berita`
--

CREATE TABLE `data_berita` (
  `id_news` int(5) NOT NULL,
  `judul` varchar(100) NOT NULL,
  `berita` text NOT NULL,
  `pengirim` varchar(30) NOT NULL,
  `jml_baca` int(6) NOT NULL,
  `tgl` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `data_berita`
--

INSERT INTO `data_berita` (`id_news`, `judul`, `berita`, `pengirim`, `jml_baca`, `tgl`) VALUES
(69, 'Perubahan iklim di Indonesia', 'lorem ipsum dolor sir amet', 'Anon', 69, '2020-03-04');

-- --------------------------------------------------------

--
-- Table structure for table `data_komentar`
--

CREATE TABLE `data_komentar` (
  `id` int(11) NOT NULL,
  `nama` varchar(20) DEFAULT NULL,
  `email` varchar(20) DEFAULT NULL,
  `url` varchar(30) DEFAULT NULL,
  `komentar` text DEFAULT NULL,
  `tgl` date DEFAULT NULL,
  `jml_komen` int(11) NOT NULL,
  `id_news` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `data_komentar`
--

INSERT INTO `data_komentar` (`id`, `nama`, `email`, `url`, `komentar`, `tgl`, `jml_komen`, `id_news`) VALUES
(1, 'Ujang', 'ujang@gmail.com', NULL, 'njir kok bisa gitu, anjir????????????????', '2020-03-05', 2, 69);

-- --------------------------------------------------------

--
-- Table structure for table `data_pengumuman`
--

CREATE TABLE `data_pengumuman` (
  `id` int(5) NOT NULL,
  `judul` varchar(100) NOT NULL,
  `isi` text DEFAULT NULL,
  `pengirim` varchar(30) NOT NULL,
  `jml_baca` int(6) NOT NULL,
  `tgl` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `data_pengumuman`
--

INSERT INTO `data_pengumuman` (`id`, `judul`, `isi`, `pengirim`, `jml_baca`, `tgl`) VALUES
(1, 'Pemicu virus corona di Indonesia', 'banyak yang kabur', 'ppy', 6699, '2020-03-08');

-- --------------------------------------------------------

--
-- Table structure for table `data_potensi`
--

CREATE TABLE `data_potensi` (
  `id` int(5) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `potensi` text DEFAULT NULL,
  `tgl` date DEFAULT NULL,
  `username` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `data_potensi`
--

INSERT INTO `data_potensi` (`id`, `nama`, `potensi`, `tgl`, `username`) VALUES
(1, 'BMKG', 'virus corona hilang selamanya', '2020-03-07', 'Admin');

-- --------------------------------------------------------

--
-- Table structure for table `data_profil`
--

CREATE TABLE `data_profil` (
  `id_profil` int(11) NOT NULL,
  `nama_profil` varchar(50) NOT NULL,
  `isi_profil` text NOT NULL,
  `username` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `data_profil`
--

INSERT INTO `data_profil` (`id_profil`, `nama_profil`, `isi_profil`, `username`) VALUES
(1, 'naverlyn', 'hai', 'naverlyn');

-- --------------------------------------------------------

--
-- Table structure for table `data_user`
--

CREATE TABLE `data_user` (
  `username` varchar(30) NOT NULL,
  `password` varchar(32) DEFAULT NULL,
  `level` varchar(10) DEFAULT NULL,
  `nama_lengkap` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `data_user`
--

INSERT INTO `data_user` (`username`, `password`, `level`, `nama_lengkap`) VALUES
('naverlyn', 'oakwoakwoakwoakw', 'Admin', 'Y');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `buku_tamu`
--
ALTER TABLE `buku_tamu`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `data_berita`
--
ALTER TABLE `data_berita`
  ADD PRIMARY KEY (`id_news`);

--
-- Indexes for table `data_komentar`
--
ALTER TABLE `data_komentar`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `data_pengumuman`
--
ALTER TABLE `data_pengumuman`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `data_potensi`
--
ALTER TABLE `data_potensi`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `data_profil`
--
ALTER TABLE `data_profil`
  ADD PRIMARY KEY (`id_profil`);

--
-- Indexes for table `data_user`
--
ALTER TABLE `data_user`
  ADD PRIMARY KEY (`username`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
