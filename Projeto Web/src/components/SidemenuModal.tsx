import React from 'react';

import { CgClose } from 'react-icons/cg';

import '../styles/components/sidemenu.css';
import '../styles/components/sidemenu-modal.css';

import Sidemenu from './Sidemenu';

interface SidemenuModalProps {
  openMenuState: [boolean, React.Dispatch<React.SetStateAction<boolean>>];
}

const SidemenuModal: React.FC<SidemenuModalProps> = ({ openMenuState }) => {
  const [openMenu, setOpenMenu] = openMenuState;

  const handleModalClick = (
    e: React.MouseEvent<HTMLDivElement, MouseEvent>
  ) => {
    setOpenMenu(false);
  };

  const handleClose = () => {
    setOpenMenu(false);
  };

  return (
    <>
      <div
        id='outsideModal'
        className={openMenu ? 'open' : 'closed'}
        onClick={handleModalClick}
      ></div>
      <div id='sidemenuModalContainer' className={openMenu ? 'open' : 'closed'}>
        <Sidemenu>
          <CgClose onClick={handleClose} className='closeSvg' />
        </Sidemenu>
      </div>
    </>
  );
};

export default SidemenuModal;
