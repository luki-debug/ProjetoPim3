import React, { useContext, useEffect, useState } from 'react';
import Header from '../components/Header';
import Sidemenu from '../components/Sidemenu';
import { RiRecordCircleFill } from 'react-icons/ri';

import '../styles/pages/home.css';
import { PieChart } from 'react-minimal-pie-chart';
import api from '../services/api';
import { userContext } from '../App';

const Home: React.FC = () => {
  const [user] = useContext(userContext);
  const [disponivel, setDisponivel] = useState(-1);
  const [retido, setRetido] = useState(-1);
  const [patrimonio, setPatrimonio] = useState(-1);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    api
      .get(`investimento/${user.id}`)
      .then((response) => {
        if (response.status === 200) {
          const {
            PatrimonioTotal,
            TotalDisponivel,
            TotalRetido,
          } = response.data;

          setDisponivel(TotalDisponivel);
          setRetido(TotalRetido);
          setPatrimonio(PatrimonioTotal);
        }

        setLoading(false);
      })
      .catch((err) => {
        console.error(err);

        setLoading(false);
      });
  }, []);

  return (
    <div id='home'>
      <Sidemenu />
      <div className='homeContent'>
        <Header />
        <div className='content'>
          <div className='chartContainer'>
            {!loading && (
              <PieChart
                animate={true}
                lineWidth={30}
                animationDuration={1000}
                data={[
                  { title: 'disponivel', value: disponivel, color: '#17ACE6' },
                  { title: 'retido', value: retido, color: '#1880E2' },
                ]}
              />
            )}
          </div>
          <div className='valuesContainer'>
            <div className='itemContainer'>
              <RiRecordCircleFill color='#17ACE6' />
              <div className='valueContainer'>
                <span className='label'>Valor Disponível:</span>
                <span className='value'>
                  {disponivel !== -1
                    ? disponivel.toLocaleString('pt-br', {
                        style: 'currency',
                        currency: 'BRL',
                      })
                    : '--'}
                </span>
              </div>
            </div>
            <div className='itemContainer'>
              <RiRecordCircleFill color='#1880E2' />
              <div className='valueContainer'>
                <span className='label'>Valor Retido:</span>
                <span className='value'>
                  {retido !== -1
                    ? retido.toLocaleString('pt-br', {
                        style: 'currency',
                        currency: 'BRL',
                      })
                    : '--'}
                </span>
              </div>
            </div>
            <div className='itemContainer'>
              <div className='valueContainer'>
                <span className='labelPatrimonio'>Patrimônio Total:</span>
                <span className='valuePatrimonio'>
                  {patrimonio !== -1
                    ? patrimonio.toLocaleString('pt-br', {
                        style: 'currency',
                        currency: 'BRL',
                      })
                    : '--'}
                </span>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Home;
